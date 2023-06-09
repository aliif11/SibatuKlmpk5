﻿using CustomMessageBox;
using MySql.Data.MySqlClient;
using SibatuKlmpk5.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibatuKlmpk5
{
    public partial class FormPeminjaman : Form
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int idUsers;
        private int idBarang;

        public FormPeminjaman()
        {
            InitializeComponent();

            server = "localhost";
            database = "sibatu";
            uid = "root";
            password = "";

            string conString = $"server={server};database={database};uid={uid};pwd={password}";
            connection = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            TextBoxEmpty();
        }

        private void TextBoxEmpty()
        {
            textBoxNIM.Texts = "";
            textBoxTelepon.Texts = "";
            textBoxWaktuAkhir.Texts = "";
            textBoxWaktuMulai.Texts = "";
            comboBoxBarang.Texts = "";
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            string nim_nip = textBoxNIM.Texts;
            string no_telp = textBoxTelepon.Texts;
            string barang = comboBoxBarang.Texts;
            string waktu_mulai = textBoxWaktuMulai.Texts;
            string waktu_akhir = textBoxWaktuAkhir.Texts;
            string query = "INSERT INTO req_peminjaman(id_users,id_barang,no_telp,tanggal,waktu_mulai,waktu_akhir) VALUES (@users,@barang,@noTelp,@tanggal,@mulai,@akhir)";

            if (validateReqPeminjaman(nim_nip, no_telp, barang, waktu_mulai, waktu_akhir))
                return;

            searchIdUsers(nim_nip);
            if (idUsers == 0)
            {
                showError("NIM atau NIP tidak ditemukan", "Gagal Pinjam Barang");
                return;
            }

            searchIdBarang(barang);

            DateTime today = DateTime.Today;
            string tanggal = today.ToString("yyyy-MM-dd");
            waktu_mulai += ":00";
            waktu_akhir += ":00";

            cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@users", idUsers);
            cmd.Parameters.AddWithValue("@barang", idBarang);
            cmd.Parameters.AddWithValue("@noTelp", no_telp);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
            cmd.Parameters.AddWithValue("@mulai", waktu_mulai);
            cmd.Parameters.AddWithValue("@akhir", waktu_akhir);

            var result = RJMessageBox.Show("Pastikan Semua Data Yang Di Input Telah Benar?",
                                              "Konfirmasi",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    RJMessageBox.Show("Terimakasih telah menggunakan Sistem Kami, Silahkan temui petugas dan ambil barang anda :)",
                                 "Barang Berhasil Di Pinjam",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    TextBoxEmpty();
                }
                catch (Exception ex)
                {
                    showError($"Data gagal di Pinjam \n" + ex.Message, "Gagal Meminjam Barang");
                    connection.Close();
                }
            }
        }

        private void showError(string errorMessage, string errorTitle)
        {
            RJMessageBox.Show(errorMessage,
                 errorTitle,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
        }

        private bool validateReqPeminjaman(string nim_nip, string no_telp, string barang, string waktu_mulai, string waktu_akhir)
        {
            if (string.IsNullOrEmpty(nim_nip) || string.IsNullOrEmpty(no_telp) || string.IsNullOrEmpty(waktu_mulai) || string.IsNullOrEmpty(waktu_akhir) || string.IsNullOrEmpty(barang))
            {
                showError("Nim, No telp, Barang, Waktu Mulai dan akhir harus di isi", "Gagal Pinjam Barang");
                return true;
            }

            if (nim_nip.Length != 9)
            {
                showError("NIM atau NIP tidak valid, NIM atau NIP harus 9 karakter", "Gagal Pinjam Barang");
                return true;
            }

            if (no_telp.Length < 12 || no_telp.Length > 13)
            {
                showError("No Telepon tidak valid", "Gagal Pinjam Barang");
                return true;
            }

            if (waktu_mulai.Length != 5 || waktu_mulai[2] != ':' || waktu_akhir.Length != 5 || waktu_akhir[2] != ':')
            {
                showError("Format Waktu tidak valid format yg benar (08:00)", "Gagal Pinjam Barang");
                return true;
            }

            if (waktu_mulai == waktu_akhir)
            {
                showError("Peminjaman tidak dapat dilakukan pada jam yang sama", "Gagal Pinjam Barang");
                return true;
            }

            try
            {
                TimeSpan timeWaktuMulai = TimeSpan.Parse(waktu_mulai);
                TimeSpan timeWaktuAkhir = TimeSpan.Parse(waktu_akhir);

                if(timeWaktuAkhir < timeWaktuMulai)
                {
                    showError("Waktu Yang Di Input Salah Waktu Awal Harus Lebih dulu daripada Waktu Akhir", "Gagal Pinjam Barang");
                    return true;
                }

                if ((timeWaktuMulai.Hours >= 0 && timeWaktuMulai.Hours <= 6) || (timeWaktuMulai.Hours >= 18 && timeWaktuMulai.Hours <= 23))
                {
                    showError("Peminjaman Hanya dapat dilakukan pada jam 07:00-17:00", "Gagal Pinjam Barang");
                    return true;
                }

            } catch(Exception ex)
            {
                showError("Waktu Yang Di Input Tidak Valid", "Gagal Pinjam Barang");
                return true;
            }
        
            return false;
        }

        private void searchIdUsers(string nim)
        {
            string query = $"SELECT id FROM users WHERE nim_nip ='{nim}'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            idUsers = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
        }

        private void searchIdBarang(string barang)
        {
            string query = $"SELECT id FROM barang WHERE nama ='{barang}'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            idBarang = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            string[] barangAvailable = getBarangAvailable();
            foreach(string barang in barangAvailable)
            {
                comboBoxBarang.Items.Add(barang);
            }
        }

        private string[] getBarangAvailable()
        {
            var resultList = new List<string>();
            MySqlCommand command;
            MySqlDataReader reader;

            command = connection.CreateCommand();
            command.CommandText = "SELECT nama FROM barang WHERE status = 1";

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                int columnCount = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        resultList.Add(reader.GetString(i));
                    }
                }
            }
            connection.Close();

            return resultList.ToArray();
        }
    }
}
