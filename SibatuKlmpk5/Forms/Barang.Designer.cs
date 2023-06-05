namespace SibatuKlmpk5.Forms
{
    partial class Barang
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
            this.labelBarang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBarang
            // 
            this.labelBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarang.AutoSize = true;
            this.labelBarang.Location = new System.Drawing.Point(362, 185);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(82, 25);
            this.labelBarang.TabIndex = 0;
            this.labelBarang.Text = "BARANG";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBarang);
            this.Name = "Barang";
            this.Text = "Barang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBarang;
    }
}