using CustomMessageBox;
using MySql.Data.MySqlClient;
using SibatuKlmpk5.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibatuKlmpk5
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
        {
            server = "localhost";
            database = "sibatu";
            uid = "root";
            password = "";

            string conString = $"server={server};database={database};uid={uid};pwd={password}";
            connection = new MySqlConnection(conString);

            InitializeComponent();
        }

        private void linkLabelFormPeminjaman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPeminjaman formPeminjaman = new FormPeminjaman();
            formPeminjaman.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Texts) || string.IsNullOrEmpty(textBoxPassword.Texts))
            {
                RJMessageBox.Show("Email atau Password Harus di isi",
                 "Gagal Login",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                return;
            }

            string salt = "sibatu";
            string email = textBoxEmail.Texts;
            string password = textBoxPassword.Texts;
            string query = $"SELECT * FROM admin WHERE email = '{email}' AND password = '{Hashing.ToSHA256(password + salt)}';";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);

            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
                connection.Close();
            }
            else
            {
                RJMessageBox.Show("Email atau Password tidak sesuai",
                 "Gagal Login",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                connection.Close();
            }
        }
    }
}
