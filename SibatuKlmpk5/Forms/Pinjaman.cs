using MySql.Data.MySqlClient;
using System;
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
    public partial class Pinjaman : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Pinjaman()
        {
            server = "localhost";
            database = "sibatu";
            uid = "root";
            password = "";

            string conString = $"server={server};database={database};uid={uid};pwd={password}";
            connection = new MySqlConnection(conString);
            InitializeComponent();
        }

        private void Pinjaman_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        public void tampilkanData()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT peminjaman.id, users.nama, barang.nama, tanggal, waktu_mulai, waktu_akhir FROM peminjaman\r\nJOIN users\r\n  ON peminjaman.id_users = users.id\r\nJOIN barang\r\n  ON peminjaman.id_barang = barang.id", connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "peminjaman");

            dataGridViewPinjaman.DataSource = ds.Tables["peminjaman"].DefaultView;
            dataGridViewPinjaman.EnableHeadersVisualStyles = false;

            dataGridStyle();
            dataGridHeaderName();
            dataGridSize();
        }

        private void dataGridStyle()
        {
            dataGridViewPinjaman.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewPinjaman.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridViewPinjaman.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
        }

        private void dataGridHeaderName()
        {
            dataGridViewPinjaman.Columns[1].HeaderText = "Nama Peminjam";
            dataGridViewPinjaman.Columns[2].HeaderText = "Nama Barang";
            dataGridViewPinjaman.Columns[3].HeaderText = "Tanggal";
            dataGridViewPinjaman.Columns[4].HeaderText = "Waktu Mulai";
            dataGridViewPinjaman.Columns[5].HeaderText = "Waktu Akhir";
        }

        private void dataGridSize()
        {
            dataGridViewPinjaman.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPinjaman.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPinjaman.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPinjaman.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPinjaman.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPinjaman.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
