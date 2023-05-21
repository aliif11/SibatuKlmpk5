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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(255, 192, 192);
            textBox1.Location = new Point(516, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "NIP SIAKAD";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(255, 192, 192);
            textBox2.Location = new Point(516, 303);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 32);
            textBox2.TabIndex = 1;
            textBox2.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AccessibleRole = AccessibleRole.TitleBar;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.YellowGreen;
            linkLabel1.Location = new Point(57, 479);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kembali ke Form Peminjaman";
            linkLabel1.VisitedLinkColor = Color.YellowGreen;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(653, 360);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(950, 539);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}