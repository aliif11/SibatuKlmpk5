namespace SibatuKlmpk5
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.linkLabelFormPeminjaman = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new RJCodeAdvance.RJControls.RJButton();
            this.textBoxEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.textBoxPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // linkLabelFormPeminjaman
            // 
            this.linkLabelFormPeminjaman.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.linkLabelFormPeminjaman.AutoSize = true;
            this.linkLabelFormPeminjaman.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelFormPeminjaman.LinkColor = System.Drawing.Color.YellowGreen;
            this.linkLabelFormPeminjaman.Location = new System.Drawing.Point(81, 798);
            this.linkLabelFormPeminjaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFormPeminjaman.Name = "linkLabelFormPeminjaman";
            this.linkLabelFormPeminjaman.Size = new System.Drawing.Size(275, 25);
            this.linkLabelFormPeminjaman.TabIndex = 2;
            this.linkLabelFormPeminjaman.TabStop = true;
            this.linkLabelFormPeminjaman.Text = "Kembali ke Form Peminjaman >>";
            this.linkLabelFormPeminjaman.VisitedLinkColor = System.Drawing.Color.YellowGreen;
            this.linkLabelFormPeminjaman.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFormPeminjaman_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(892, 575);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 60);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.BorderColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxEmail.BorderRadius = 0;
            this.textBoxEmail.BorderSize = 2;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(823, 403);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxEmail.PasswordChar = false;
            this.textBoxEmail.PlaceholderColor = System.Drawing.Color.Black;
            this.textBoxEmail.PlaceholderText = "Email";
            this.textBoxEmail.Size = new System.Drawing.Size(375, 47);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Texts = "";
            this.textBoxEmail.UnderlinedStyle = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderRadius = 0;
            this.textBoxPassword.BorderSize = 2;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(823, 475);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.Black;
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(375, 47);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 898);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkLabelFormPeminjaman);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabelFormPeminjaman;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJButton btnLogin;
        private RJCodeAdvance.RJControls.RJTextBox textBoxEmail;
        private RJCodeAdvance.RJControls.RJTextBox textBoxPassword;
    }
}