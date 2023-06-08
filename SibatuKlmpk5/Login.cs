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
        public Login()
        {
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
           Dashboard dashboard = new Dashboard();
           dashboard.Show();
           this.Hide();
        }
    }
}
