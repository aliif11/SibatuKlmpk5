using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SibatuKlmpk5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            rjProgressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rjProgressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

            if(rjProgressBar1.Value < rjProgressBar1.Maximum)
            {
                rjProgressBar1.Value++;
            }
        }
    }
}
