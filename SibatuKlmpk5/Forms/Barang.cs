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
using CustomMessageBox;
using System.Data.SqlTypes;

namespace SibatuKlmpk5.Forms
{
    public partial class Barang : Form
    {
        private int selectedId;
        private int statusBarang;
        private string kodeBarangEdit;
        private string namaBarangEdit;
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

        public void Barang_Load(object sender, EventArgs e)
        {
            tampilkanData();
        }

        public void tampilkanData()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM barang", connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "barang");

            dataGridViewBarang.DataSource = ds.Tables["barang"].DefaultView;
            dataGridViewBarang.EnableHeadersVisualStyles = false;
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
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
            if (isIdNotSelected())
                return;
            int[] btnColor = { 13, 110, 253 };
            OpenTambahEditForm("Edit Barang", "Edit", btnColor, kodeBarangEdit, namaBarangEdit);
        }

        private void OpenTambahEditForm(string labelText, string btnText, int[] color, string kodeBarang = "", string namaBarang = "")
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
                tambahEditBarang.textBoxKodeBarang.Texts = kodeBarang;
                tambahEditBarang.textBoxNamaBarang.Texts = namaBarang;
                tambahEditBarang.textBoxId.Texts = selectedId.ToString();
                tambahEditBarang.textBoxNamaBarangOld.Texts = namaBarang;
                tambahEditBarang.ShowDialog();
                this.tampilkanData();
            }
        }

        private void dataGridViewBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = Convert.ToInt32(dataGridViewBarang.Rows[e.RowIndex].Cells[0].Value);
            RJMessageBox.Show("Anda Memilih id barang: " + selectedId,
                             "Pilih id Barang",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
            kodeBarangEdit = dataGridViewBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            namaBarangEdit = dataGridViewBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnHapusBarang_Click(object sender, EventArgs e)
        {
            if (isIdNotSelected())
                return;
            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM barang WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedId);

            var result = RJMessageBox.Show($"Anda yakin ingin menghapus data dengan id: {selectedId} ?",
                                               "Konfirmasi",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
               try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    RJMessageBox.Show(namaBarangEdit + " Telah Dihapus",
                             "Berhasil Menghapus Barang",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                    tampilkanData();
                    connection.Close();
                } catch(Exception ex)
                {
                    RJMessageBox.Show("Data gagal di dihapus \n" + ex.Message,
                                      "Gagal Menghapus Barang",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }

        private bool isIdNotSelected()
        {
            if (selectedId == 0)
            {
                RJMessageBox.Show("Anda Harus memilih id barang",
                              "Pilih Id Barang",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void textBoxSearch__TextChanged(object sender, EventArgs e)
        {
            searchData(textBoxSearch.Texts);
        }

        private void searchData(string valueToFind)
        {
            string query = $"SELECT * FROM barang WHERE nama LIKE'%{valueToFind}%' OR kode LIKE'%{valueToFind}%'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "barang");

            dataGridViewBarang.DataSource = ds.Tables["barang"].DefaultView;
        }

        private void btnUbahStatus_Click(object sender, EventArgs e)
        {
            if (isIdNotSelected())
                return;

            getStatusBarang();
            int statusToChange = (statusBarang == 1) ? 0 : 1;

            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE barang SET status = {statusToChange} WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", selectedId);

            string statusMsg = (statusBarang == 1) ? "tidak tersedia" : "tersedia";
            var result = RJMessageBox.Show($"Apakah anda ingin mengubah status barang dengan id: {selectedId} menjadi {statusMsg}?",
                                              "Konfirmasi",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    RJMessageBox.Show("Status " + namaBarangEdit + " Telah Diubah",
                             "Berhasil Mengubah Status Barang",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                    tampilkanData();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Status Barang Gagal diubah \n" + ex.Message,
                                      "Gagal Mengubah Status Barang",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }

        private void getStatusBarang()
        {
            MySqlCommand command = new MySqlCommand();
            command = connection.CreateCommand();
            command.CommandText = "SELECT status FROM barang WHERE id = @id";
            command.Parameters.AddWithValue("@id", selectedId);
            connection.Open();
            statusBarang = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
        }
    }
}
