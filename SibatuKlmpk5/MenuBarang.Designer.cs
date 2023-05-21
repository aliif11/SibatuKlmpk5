namespace SibatuKlmpk5
{
    partial class MenuBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBarang));
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(-2, 492);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(40, 0, 0, 0);
            button1.Size = new Size(220, 49);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.YellowGreen;
            label9.ImeMode = ImeMode.Off;
            label9.Location = new Point(0, 193);
            label9.Name = "label9";
            label9.Padding = new Padding(60, 5, 53, 5);
            label9.Size = new Size(204, 35);
            label9.TabIndex = 13;
            label9.Text = "Pinjaman";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.WindowFrame;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.YellowGreen;
            label8.ImeMode = ImeMode.Off;
            label8.Location = new Point(0, 158);
            label8.Name = "label8";
            label8.Padding = new Padding(60, 5, 85, 5);
            label8.Size = new Size(217, 35);
            label8.TabIndex = 12;
            label8.Text = "Barang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.YellowGreen;
            label7.ImeMode = ImeMode.Off;
            label7.Location = new Point(0, 121);
            label7.Name = "label7";
            label7.Padding = new Padding(60, 5, 53, 5);
            label7.Size = new Size(217, 35);
            label7.TabIndex = 11;
            label7.Text = "Dashboard";
            // 
            // MenuBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 541);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "MenuBarang";
            Text = "MenuBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}