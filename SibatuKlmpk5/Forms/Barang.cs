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
using SibatuKlmpk5;

namespace SibatuKlmpk5.Forms
{
    public partial class Barang : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private Dashboard dashboard;

        public Barang()
        {
            server = "localhost";
            database = "sibatu";
            uid = "root";
            password = "";

            string conString = $"server={server};database={database};uid={uid};pwd={password}";
            connection = new MySqlConnection(conString);
            dashboard = new Dashboard();
            InitializeComponent();
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        private void tampilkanData()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM barang", connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "barang");

            dataGridViewBarang.DataSource = ds.Tables["barang"].DefaultView;
            dataGridViewBarang.EnableHeadersVisualStyles = false;
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217,217,217);
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial",9, FontStyle.Bold);
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
            dataGridViewBarang.Columns[1].HeaderText = "Kode Barang";
            dataGridViewBarang.Columns[2].HeaderText = "Nama Barang";
            dataGridViewBarang.Columns[3].HeaderText = "Status Barang";

            dataGridViewBarang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBarang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            int[] btnColor = { 25, 135, 84 };
            OpenTambahEditForm("Tambah Barang", "Tambah", btnColor);
        }

        private void btnEditBarang_Click(object sender, EventArgs e)
        {
            int[] btnColor = { 13, 110, 253 };
            OpenTambahEditForm("Edit Barang", "Edit", btnColor);
        }

        private void OpenTambahEditForm(string labelText, string btnText, int[] color)
        {
            if ((Application.OpenForms["TambahEditBarang"] as TambahEditBarang) != null)
            {
                return;
            }
            else
            {
                TambahEditBarang tambahEditBarang = new TambahEditBarang();
                tambahEditBarang.Text = labelText;
                tambahEditBarang.labelTambahEditBarang.Text = labelText;
                tambahEditBarang.btnTambahEditBarang.Text = btnText;
                tambahEditBarang.btnTambahEditBarang.BackColor = Color.FromArgb(color[0], color[1], color[2]);
                tambahEditBarang.Show();
            }
        }
    }
}
