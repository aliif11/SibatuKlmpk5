using System;
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
        public FormPeminjaman()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            textBoxNIM.Texts = "";
            textBoxTelepon.Texts = "";
            textBoxWaktuAkhir.Texts = "";
            textBoxWaktuMulai.Texts = "";
        }
    }
}
