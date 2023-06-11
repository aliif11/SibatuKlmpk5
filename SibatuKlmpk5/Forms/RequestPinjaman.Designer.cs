namespace SibatuKlmpk5.Forms
{
    partial class RequestPinjaman
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
            this.btnSearch = new RJCodeAdvance.RJControls.RJButton();
            this.textBoxSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewReqPinjaman = new System.Windows.Forms.DataGridView();
            this.labelPinjaman = new System.Windows.Forms.Label();
            this.btnTambahBarang = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqPinjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(743, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.BorderColor = System.Drawing.Color.Black;
            this.textBoxSearch.BorderFocusColor = System.Drawing.Color.LimeGreen;
            this.textBoxSearch.BorderRadius = 0;
            this.textBoxSearch.BorderSize = 2;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(123, 93);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxSearch.PasswordChar = false;
            this.textBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(510, 39);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.Texts = "";
            this.textBoxSearch.UnderlinedStyle = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(27, 93);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(89, 30);
            this.labelSearch.TabIndex = 15;
            this.labelSearch.Text = "Search :";
            // 
            // dataGridViewReqPinjaman
            // 
            this.dataGridViewReqPinjaman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReqPinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReqPinjaman.Location = new System.Drawing.Point(27, 161);
            this.dataGridViewReqPinjaman.Name = "dataGridViewReqPinjaman";
            this.dataGridViewReqPinjaman.RowHeadersWidth = 62;
            this.dataGridViewReqPinjaman.RowTemplate.Height = 33;
            this.dataGridViewReqPinjaman.Size = new System.Drawing.Size(857, 581);
            this.dataGridViewReqPinjaman.TabIndex = 14;
            // 
            // labelPinjaman
            // 
            this.labelPinjaman.AutoSize = true;
            this.labelPinjaman.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPinjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.labelPinjaman.Location = new System.Drawing.Point(20, 18);
            this.labelPinjaman.Name = "labelPinjaman";
            this.labelPinjaman.Size = new System.Drawing.Size(287, 45);
            this.labelPinjaman.TabIndex = 13;
            this.labelPinjaman.Text = "Request Pinjaman";
            // 
            // btnTambahBarang
            // 
            this.btnTambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnTambahBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnTambahBarang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTambahBarang.BorderRadius = 0;
            this.btnTambahBarang.BorderSize = 0;
            this.btnTambahBarang.FlatAppearance.BorderSize = 0;
            this.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambahBarang.ForeColor = System.Drawing.Color.White;
            this.btnTambahBarang.Location = new System.Drawing.Point(908, 161);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(163, 78);
            this.btnTambahBarang.TabIndex = 18;
            this.btnTambahBarang.Text = "Setujui Peminjaman";
            this.btnTambahBarang.TextColor = System.Drawing.Color.White;
            this.btnTambahBarang.UseVisualStyleBackColor = false;
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 796);
            this.Controls.Add(this.dataGridViewReqPinjaman);
            this.Controls.Add(this.btnTambahBarang);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelPinjaman);
            this.Name = "Dash";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReqPinjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnSearch;
        private RJCodeAdvance.RJControls.RJTextBox textBoxSearch;
        private Label labelSearch;
        private DataGridView dataGridViewReqPinjaman;
        private Label labelPinjaman;
        private RJCodeAdvance.RJControls.RJButton btnTambahBarang;
    }
}