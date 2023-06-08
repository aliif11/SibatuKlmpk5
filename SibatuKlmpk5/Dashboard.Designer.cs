namespace SibatuKlmpk5
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPinjaman = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnPinjaman);
            this.panelMenu.Controls.Add(this.btnBarang);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 898);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.btnLogout.Image = global::SibatuKlmpk5.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 336);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(260, 70);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPinjaman
            // 
            this.btnPinjaman.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPinjaman.FlatAppearance.BorderSize = 0;
            this.btnPinjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPinjaman.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPinjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.btnPinjaman.Image = global::SibatuKlmpk5.Properties.Resources.pinjaman;
            this.btnPinjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPinjaman.Location = new System.Drawing.Point(0, 266);
            this.btnPinjaman.Name = "btnPinjaman";
            this.btnPinjaman.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPinjaman.Size = new System.Drawing.Size(260, 70);
            this.btnPinjaman.TabIndex = 3;
            this.btnPinjaman.Text = " Pinjaman";
            this.btnPinjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPinjaman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPinjaman.UseVisualStyleBackColor = true;
            this.btnPinjaman.Click += new System.EventHandler(this.btnPinjaman_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarang.FlatAppearance.BorderSize = 0;
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.btnBarang.Image = global::SibatuKlmpk5.Properties.Resources.barang;
            this.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarang.Location = new System.Drawing.Point(0, 196);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBarang.Size = new System.Drawing.Size(260, 70);
            this.btnBarang.TabIndex = 2;
            this.btnBarang.Text = " Barang";
            this.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.btnDashboard.Image = global::SibatuKlmpk5.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 126);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(260, 70);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 126);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SibatuKlmpk5.Properties.Resources.sibatu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(260, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1097, 51);
            this.panelTop.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(260, 847);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1097, 51);
            this.panelBottom.TabIndex = 2;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(260, 51);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1097, 796);
            this.panelContainer.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SibatuKlmpk5.Properties.Resources.Splash_Screen;
            this.pictureBox2.Location = new System.Drawing.Point(235, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(723, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 898);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnPinjaman;
        private Button btnBarang;
        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelContainer;
        private PictureBox pictureBox2;
    }
}