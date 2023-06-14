using CustomMessageBox;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibatuKlmpk5.Forms
{
    public partial class RequestPinjaman : Form
    {
        private int selectedId;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public RequestPinjaman()
        {
            server = "localhost";
            database = "sibatu";
            uid = "root";
            password = "";

            string conString = $"server={server};database={database};uid={uid};pwd={password}";
            connection = new MySqlConnection(conString);
            InitializeComponent();
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        public void tampilkanData()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT req_peminjaman.id, users.nama, barang.nama, tanggal, waktu_mulai, waktu_akhir FROM req_peminjaman\r\nJOIN users\r\n  ON req_peminjaman.id_users = users.id\r\nJOIN barang\r\n  ON req_peminjaman.id_barang = barang.id", connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "req_peminjaman");

            dataGridViewReqPinjaman.DataSource = ds.Tables["req_peminjaman"].DefaultView;
            dataGridViewReqPinjaman.EnableHeadersVisualStyles = false;

            dataGridStyle();
            dataGridHeaderName();
            dataGridSize();
        }

        private void dataGridStyle()
        {
            dataGridViewReqPinjaman.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewReqPinjaman.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridViewReqPinjaman.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
        }

        private void dataGridHeaderName()
        {
            dataGridViewReqPinjaman.Columns[1].HeaderText = "Nama Peminjam";
            dataGridViewReqPinjaman.Columns[2].HeaderText = "Nama Barang";
            dataGridViewReqPinjaman.Columns[3].HeaderText = "Tanggal";
            dataGridViewReqPinjaman.Columns[4].HeaderText = "Waktu Mulai";
            dataGridViewReqPinjaman.Columns[5].HeaderText = "Waktu Akhir";
        }

        private void dataGridSize()
        {
            dataGridViewReqPinjaman.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewReqPinjaman.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewReqPinjaman.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewReqPinjaman.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewReqPinjaman.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewReqPinjaman.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            if (isIdNotSelected())
                return;

            List<object> value = getReqPeminjamanValue();
            MySqlCommand cmd;
            MySqlCommand sqlCmd;
            MySqlCommand command;

            command = connection.CreateCommand();
            cmd = connection.CreateCommand();
            sqlCmd = connection.CreateCommand();

            command.CommandText = "INSERT INTO peminjaman(id_users,id_barang,tanggal,waktu_mulai,waktu_akhir) VALUES (@users,@barang,@tanggal,@mulai,@akhir)";
            command.Parameters.AddWithValue("@users", value[1]);
            command.Parameters.AddWithValue("@barang", value[2]);
            command.Parameters.AddWithValue("@tanggal", value[3]);
            command.Parameters.AddWithValue("@mulai", value[4]);
            command.Parameters.AddWithValue("@akhir", value[5]);

            cmd.CommandText = "DELETE FROM req_peminjaman WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedId);

            sqlCmd.CommandText = "UPDATE barang SET status = 0 WHERE id = @id";
            sqlCmd.Parameters.AddWithValue("@id", value[2]);

            var result = RJMessageBox.Show($"Anda yakin ingin menyutujui peminjaman dengan id: {selectedId} ?",
                                               "Konfirmasi",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);
           if(result.ToString() == "Yes")
           {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    sqlCmd.ExecuteNonQuery();
                    connection.Close();
                    RJMessageBox.Show("Terimakasih telah menggunakan Sistem Kami, Silahkan berikan barang kepada peminjam :)",
                                 "Peminjaman disetujui",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    tampilkanData();
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show($"Data gagal di Setujui \n" + ex.Message,
                     "Gagal Menyetujui Peminjaman Barang",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    connection.Close();
                }
           }
        }

        private void dataGridViewReqPinjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dataGridViewReqPinjaman.Rows[e.RowIndex].Cells[0].Value);
            RJMessageBox.Show("Anda Memilih permintaan peminjaman dengan id : " + selectedId,
                             "Pilih id Peminjaman",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private bool isIdNotSelected()
        {
            if (selectedId == 0)
            {
                RJMessageBox.Show("Anda Harus memilih id Peminjaman",
                              "Pilih Id Peminjaman",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private List<object> getReqPeminjamanValue()
        {
            var resultList = new List<object>();
            MySqlCommand command;
            MySqlDataReader reader;

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM req_peminjaman WHERE id = @id";
            command.Parameters.AddWithValue("@id", selectedId);

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                int columnCount = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        resultList.Add(reader.GetValue(i));
                    }
                }
            }
            connection.Close();

            return resultList;
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {
            searchData(textBoxSearch.Texts);
        }

        private void searchData(string valueToFind)
        {
            string query = $"SELECT req_peminjaman.id, users.nama, barang.nama, tanggal, waktu_mulai, waktu_akhir FROM req_peminjaman\r\nJOIN users\r\n  ON req_peminjaman.id_users = users.id\r\nJOIN barang\r\n  ON req_peminjaman.id_barang = barang.id WHERE users.nama LIKE'%{valueToFind}%' OR barang.nama LIKE'%{valueToFind}%'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "req_peminjaman");

            dataGridViewReqPinjaman.DataSource = ds.Tables["req_peminjaman"].DefaultView;
            dataGridViewReqPinjaman.EnableHeadersVisualStyles = false;
        }

        private void btnTolakPeminjaman_Click(object sender, EventArgs e)
        {
            if (isIdNotSelected())
                return;

            MySqlCommand cmd;

            cmd = connection.CreateCommand();

            cmd.CommandText = "DELETE FROM req_peminjaman WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedId);


            var result = RJMessageBox.Show($"Anda yakin ingin menolak peminjaman dengan data id: {selectedId} ?",
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
                    RJMessageBox.Show("Peminjaman di Tolak, Permintaan Peminjaman dihapus",
                                 "Peminjaman di Tolak",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    tampilkanData();
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show($"Data gagal di Setujui \n" + ex.Message,
                     "Gagal Menyetujui Peminjaman Barang",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }
    }
}
