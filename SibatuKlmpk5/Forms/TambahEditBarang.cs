using CustomMessageBox;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibatuKlmpk5.Forms
{
    public partial class TambahEditBarang : Form
    {
        private int selectedId;
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private string server;
        private string database;
        private string uid;
        private string password;

        public TambahEditBarang()
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

        private void showError(string errorMessage, string errorTitle)
        {
            RJMessageBox.Show(errorMessage,
                 errorTitle,
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
        }

        private void showSuccess(string errorMessage, string errorTitle)
        {
            RJMessageBox.Show(errorMessage,
                              errorTitle,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
        }

        private void btnTambahEditBarang_Click(object sender, EventArgs e)
        {
            string kodeBarang = textBoxKodeBarang.Texts;
            string namaBarang = textBoxNamaBarang.Texts;
            string id = textBoxId.Texts;
            string namaBarangOld = textBoxNamaBarangOld.Texts;
            string errorTitle = (btnTambahEditBarang.Text == "Tambah") ? "Tambah" : "Edit";
            string query = (btnTambahEditBarang.Text == "Tambah") ? "INSERT INTO barang(kode,nama) VALUES (@kode,@nama)" : "UPDATE barang SET kode = @kode, nama = @nama WHERE id = @id";

            if (validateBarang(kodeBarang, namaBarang, errorTitle))
                return;
            
            cmd = connection.CreateCommand();
            cmd.CommandText = query;

            if (btnTambahEditBarang.Text == "Edit")
                cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@kode", kodeBarang);
            cmd.Parameters.AddWithValue("@nama", namaBarang);
            

            if(btnTambahEditBarang.Text == "Edit")
            {
                var result = RJMessageBox.Show($"Anda yakin ingin mengupdate data dengan id: {id} ?",
                                                "Konfirmasi",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
                if(result.ToString() == "Yes")
                {
                    tambahEditLogic("Edit", errorTitle, namaBarangOld);
                }
                
            } else
            {
                tambahEditLogic("Tambah", errorTitle, namaBarang);
            }
        }

        private bool validateBarang(string kodeBarang, string namaBarang, string errorTitle)
        {
            if (string.IsNullOrEmpty(kodeBarang) || string.IsNullOrEmpty(namaBarang))
            {
                showError("Kode Barang dan Nama Barang Harus Diisi", $"Gagal {errorTitle} Barang");
                return true;
            }

            if (namaBarang.Length < 3 || namaBarang.Length > 25)
            {
                showError("Nama barang harus diantara 3 sampai 25 karakter", $"Gagal {errorTitle} Barang");
                return true;
            }

            if (kodeBarang.Length < 5 || kodeBarang.Length > 5)
            {
                showError("Kode Barang Harus 5 Digit", $"Gagal Tambah Barang");
                return true;
            }

            if (!Char.IsLetter(kodeBarang, 0) || !Char.IsLetter(kodeBarang, 1) || !Char.IsDigit(kodeBarang, 2) || !Char.IsDigit(kodeBarang, 3) || !Char.IsDigit(kodeBarang, 4))
            {
                showError("Format Kode Barang Salah, Contoh Format Yang Benar (AA001)", $"Gagal {errorTitle} Barang");
                return true;
            }

            return false;
        }

        private void tambahEditLogic(string tipe, string errorTitle, string namaBarang)
        {
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                if(tipe == "Tambah")
                {
                    showSuccess(namaBarang + " Telah Ditambahkan", "Berhasil Menambah Barang");
                } else
                {
                    showSuccess(namaBarang + " Telah Diedit", "Berhasil Mengedit Barang");
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                showError($"Data gagal di {errorTitle} \n" + ex.Message, $"Gagal {errorTitle} Barang");
                connection.Close();
            }
        }
    }
}
