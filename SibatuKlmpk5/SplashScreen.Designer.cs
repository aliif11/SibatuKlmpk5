namespace SibatuKlmpk5
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjProgressBar1 = new RJCodeAdvance.RJControls.RJProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SibatuKlmpk5.Properties.Resources.Splash_Screen;
            this.pictureBox1.Location = new System.Drawing.Point(318, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar1.ChannelHeight = 12;
            this.rjProgressBar1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.rjProgressBar1.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar1.Location = new System.Drawing.Point(463, 567);
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = false;
            this.rjProgressBar1.ShowValue = RJCodeAdvance.RJControls.TextPosition.Center;
            this.rjProgressBar1.Size = new System.Drawing.Size(424, 46);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.rjProgressBar1.SliderHeight = 6;
            this.rjProgressBar1.Step = 15;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 898);
            this.Controls.Add(this.rjProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1379, 954);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJProgressBar rjProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}