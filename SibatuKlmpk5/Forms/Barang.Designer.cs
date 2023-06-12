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
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnTambahBarang = new RJCodeAdvance.RJControls.RJButton();
            this.btnEditBarang = new RJCodeAdvance.RJControls.RJButton();
            this.btnHapusBarang = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBarang
            // 
            this.labelBarang.AutoSize = true;
            this.labelBarang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(169)))), ((int)(((byte)(88)))));
            this.labelBarang.Location = new System.Drawing.Point(21, 20);
            this.labelBarang.Name = "labelBarang";
            this.labelBarang.Size = new System.Drawing.Size(232, 45);
            this.labelBarang.TabIndex = 0;
            this.labelBarang.Text = "Daftar Barang";
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(28, 161);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 62;
            this.dataGridViewBarang.RowTemplate.Height = 33;
            this.dataGridViewBarang.Size = new System.Drawing.Size(857, 581);
            this.dataGridViewBarang.TabIndex = 1;
            this.dataGridViewBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(28, 93);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(89, 30);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Search :";
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
            this.textBoxSearch.Location = new System.Drawing.Point(124, 93);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Multiline = false;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxSearch.PasswordChar = false;
            this.textBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSearch.PlaceholderText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(510, 39);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Texts = "";
            this.textBoxSearch.UnderlinedStyle = false;
            this.textBoxSearch._TextChanged += new System.EventHandler(this.textBoxSearch__TextChanged);
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
            this.btnTambahBarang.Location = new System.Drawing.Point(933, 161);
            this.btnTambahBarang.Name = "btnTambahBarang";
            this.btnTambahBarang.Size = new System.Drawing.Size(141, 50);
            this.btnTambahBarang.TabIndex = 5;
            this.btnTambahBarang.Text = "Tambah";
            this.btnTambahBarang.TextColor = System.Drawing.Color.White;
            this.btnTambahBarang.UseVisualStyleBackColor = false;
            this.btnTambahBarang.Click += new System.EventHandler(this.btnTambahBarang_Click);
            // 
            // btnEditBarang
            // 
            this.btnEditBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEditBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnEditBarang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditBarang.BorderRadius = 0;
            this.btnEditBarang.BorderSize = 0;
            this.btnEditBarang.FlatAppearance.BorderSize = 0;
            this.btnEditBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditBarang.ForeColor = System.Drawing.Color.White;
            this.btnEditBarang.Location = new System.Drawing.Point(933, 240);
            this.btnEditBarang.Name = "btnEditBarang";
            this.btnEditBarang.Size = new System.Drawing.Size(141, 50);
            this.btnEditBarang.TabIndex = 6;
            this.btnEditBarang.Text = "Edit";
            this.btnEditBarang.TextColor = System.Drawing.Color.White;
            this.btnEditBarang.UseVisualStyleBackColor = false;
            this.btnEditBarang.Click += new System.EventHandler(this.btnEditBarang_Click);
            // 
            // btnHapusBarang
            // 
            this.btnHapusBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapusBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnHapusBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.btnHapusBarang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHapusBarang.BorderRadius = 0;
            this.btnHapusBarang.BorderSize = 0;
            this.btnHapusBarang.FlatAppearance.BorderSize = 0;
            this.btnHapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapusBarang.ForeColor = System.Drawing.Color.White;
            this.btnHapusBarang.Location = new System.Drawing.Point(933, 318);
            this.btnHapusBarang.Name = "btnHapusBarang";
            this.btnHapusBarang.Size = new System.Drawing.Size(141, 50);
            this.btnHapusBarang.TabIndex = 7;
            this.btnHapusBarang.Text = "Hapus";
            this.btnHapusBarang.TextColor = System.Drawing.Color.White;
            this.btnHapusBarang.UseVisualStyleBackColor = false;
            this.btnHapusBarang.Click += new System.EventHandler(this.btnHapusBarang_Click);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 796);
            this.Controls.Add(this.btnHapusBarang);
            this.Controls.Add(this.btnEditBarang);
            this.Controls.Add(this.btnTambahBarang);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.labelBarang);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelSearch;
        private RJCodeAdvance.RJControls.RJTextBox textBoxSearch;
        private RJCodeAdvance.RJControls.RJButton btnTambahBarang;
        private RJCodeAdvance.RJControls.RJButton btnEditBarang;
        private RJCodeAdvance.RJControls.RJButton btnHapusBarang;
        private DataGridView dataGridViewBarang;
        public Label labelBarang;
    }
}