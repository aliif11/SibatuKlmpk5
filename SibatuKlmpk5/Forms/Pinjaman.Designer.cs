namespace SibatuKlmpk5.Forms
{
    partial class Pinjaman
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
            this.labelPinjaman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPinjaman
            // 
            this.labelPinjaman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPinjaman.AutoSize = true;
            this.labelPinjaman.Location = new System.Drawing.Point(344, 177);
            this.labelPinjaman.Name = "labelPinjaman";
            this.labelPinjaman.Size = new System.Drawing.Size(99, 25);
            this.labelPinjaman.TabIndex = 0;
            this.labelPinjaman.Text = "PINJAMAN";
            // 
            // Pinjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPinjaman);
            this.Name = "Pinjaman";
            this.Text = "Pinjaman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPinjaman;
    }
}