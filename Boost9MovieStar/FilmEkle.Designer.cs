namespace Boost9MovieStar
{
    partial class FilmEkle
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
            this.components = new System.ComponentModel.Container();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.FilmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImdbPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmId,
            this.FilmAd,
            this.Yil,
            this.ImdbPuani,
            this.TurId});
            this.dgvFilmler.Location = new System.Drawing.Point(34, 70);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.Size = new System.Drawing.Size(548, 226);
            this.dgvFilmler.TabIndex = 13;
            this.dgvFilmler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // FilmId
            // 
            this.FilmId.HeaderText = "Id";
            this.FilmId.Name = "FilmId";
            // 
            // FilmAd
            // 
            this.FilmAd.HeaderText = "Ad";
            this.FilmAd.Name = "FilmAd";
            // 
            // Yil
            // 
            this.Yil.HeaderText = "Yıl";
            this.Yil.Name = "Yil";
            // 
            // ImdbPuani
            // 
            this.ImdbPuani.HeaderText = "IMDB";
            this.ImdbPuani.Name = "ImdbPuani";
            // 
            // TurId
            // 
            this.TurId.HeaderText = "Tür Id";
            this.TurId.Name = "TurId";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(447, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Film Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFilmler);
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImdbPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}