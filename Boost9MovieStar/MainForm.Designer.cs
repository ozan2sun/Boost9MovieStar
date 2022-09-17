namespace Boost9MovieStar
{
    partial class MainForm
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
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oyuncular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilmEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.pboFilmPoster = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.AllowUserToDeleteRows = false;
            this.dgvFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Poster,
            this.Yil,
            this.imdbPuani,
            this.imdbId,
            this.TurAd,
            this.Oyuncular});
            this.dgvFilmler.Location = new System.Drawing.Point(12, 159);
            this.dgvFilmler.MultiSelect = false;
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.RowHeadersVisible = false;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(776, 263);
            this.dgvFilmler.TabIndex = 0;
            this.dgvFilmler.SelectionChanged += new System.EventHandler(this.dgvFilmler_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.Name = "Poster";
            this.Poster.ReadOnly = true;
            // 
            // Yil
            // 
            this.Yil.HeaderText = "Yıl";
            this.Yil.Name = "Yil";
            this.Yil.ReadOnly = true;
            // 
            // imdbPuani
            // 
            this.imdbPuani.HeaderText = "IMDB Puanı";
            this.imdbPuani.Name = "imdbPuani";
            this.imdbPuani.ReadOnly = true;
            // 
            // imdbId
            // 
            this.imdbId.HeaderText = "IMDB ID";
            this.imdbId.Name = "imdbId";
            this.imdbId.ReadOnly = true;
            // 
            // TurAd
            // 
            this.TurAd.HeaderText = "Tür Adı";
            this.TurAd.Name = "TurAd";
            this.TurAd.ReadOnly = true;
            // 
            // Oyuncular
            // 
            this.Oyuncular.HeaderText = "Oyuncular";
            this.Oyuncular.Name = "Oyuncular";
            this.Oyuncular.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOyuncular,
            this.tsmiTurler,
            this.tsmiFilmEkle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(74, 20);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // tsmiTurler
            // 
            this.tsmiTurler.Name = "tsmiTurler";
            this.tsmiTurler.Size = new System.Drawing.Size(49, 20);
            this.tsmiTurler.Text = "Türler";
            this.tsmiTurler.Click += new System.EventHandler(this.tsmiTurler_Click);
            // 
            // tsmiFilmEkle
            // 
            this.tsmiFilmEkle.Name = "tsmiFilmEkle";
            this.tsmiFilmEkle.Size = new System.Drawing.Size(63, 20);
            this.tsmiFilmEkle.Text = "FilmEkle";
            this.tsmiFilmEkle.Click += new System.EventHandler(this.tsmiFilmEkle_Click);
            // 
            // pboFilmPoster
            // 
            this.pboFilmPoster.Location = new System.Drawing.Point(335, 12);
            this.pboFilmPoster.Name = "pboFilmPoster";
            this.pboFilmPoster.Size = new System.Drawing.Size(146, 141);
            this.pboFilmPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFilmPoster.TabIndex = 2;
            this.pboFilmPoster.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(575, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pboFilmPoster);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oyuncular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurler;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilmEkle;
        private System.Windows.Forms.PictureBox pboFilmPoster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

