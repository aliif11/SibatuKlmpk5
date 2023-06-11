using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
