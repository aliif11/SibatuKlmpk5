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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.LimeGreen;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.GrayText;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Red;
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.Snow;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = SystemColors.WindowFrame;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.ForeColor = Color.YellowGreen;
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.YellowGreen;
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.YellowGreen;
            label9.Name = "label9";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Show;
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}