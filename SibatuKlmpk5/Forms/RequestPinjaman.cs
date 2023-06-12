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

            string[] value = getReqPeminjamanValue();
            MySqlCommand cmd;
            MySqlCommand command;
            string tanggalFormat = getTanggalFormat(value[3]);

            command = connection.CreateCommand();
            cmd = connection.CreateCommand();

            command.CommandText = "INSERT INTO peminjaman(id_users,id_barang,tanggal,waktu_mulai,waktu_akhir) VALUES (@users,@barang,@tanggal,@mulai,@akhir)";
            command.Parameters.AddWithValue("@users", value[1]);
            command.Parameters.AddWithValue("@barang", value[2]);
            command.Parameters.AddWithValue("@tanggal", tanggalFormat);
            command.Parameters.AddWithValue("@mulai", value[4]);
            command.Parameters.AddWithValue("@akhir", value[5]);

            cmd.CommandText = "DELETE FROM req_peminjaman WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedId);

            var result = RJMessageBox.Show($"Anda yakin ingin menghapus data dengan id: {selectedId} ?",
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
                    connection.Close();
                    RJMessageBox.Show("Terimakasih telah menggunakan Sistem Kami, Silahkan berikan barang kepada peminjam :)",
                                 "Peminjaman disetujui",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
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
            RJMessageBox.Show("Anda Memilih id barang: " + selectedId,
                             "Pilih id Barang",
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

        private string[] getReqPeminjamanValue()
        {
            var resultList = new List<string>();
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

                // Read the data and display it in the console
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

        private string getTanggalFormat(string tanggal)
        {
            int hari = Convert.ToInt32(tanggal.Substring(0, 2));
            int bulan = Convert.ToInt32(tanggal.Substring(3, 2));
            int tahun = Convert.ToInt32(tanggal.Substring(6, 4));
            DateTime dateTime= new DateTime(tahun,bulan,hari);
            return dateTime.ToString("yyyy-MM-dd");
        }
    }
}
