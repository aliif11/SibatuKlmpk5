using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SibatuKlmpk5
{
    public partial class Dashboard : Form
    {
        private Button currentBtn;
        private Form activeForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActiveButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                if(currentBtn != (Button)senderBtn)
                {
                    DisableButton();
                    currentBtn = (Button)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(75,15,169,88);
                    currentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 15, 169, 88);
                    currentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 217, 153);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control control in panelMenu.Controls)
            {
                Button previousBtn;
                if (control.GetType() == typeof(Button))
                {
                    previousBtn = (Button)control;
                    previousBtn.BackColor = Color.FromArgb(71, 66, 66);
                    previousBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 79, 79);
                    previousBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 79, 79);
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Barang(), sender);
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pinjaman(), sender);
        }
    }
}
