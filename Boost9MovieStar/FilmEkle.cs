using Boost9MovieStar.Data;
using Boost9MovieStar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boost9MovieStar
{
    public partial class FilmEkle : Form
    {
        private readonly MovieDBContext db;
        private readonly int id;

        public FilmEkle(MovieDBContext db, int id)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            Guncelle();
        }
       

        public void Guncelle()
        {
            dgvFilmler.Rows.Clear();
            foreach (var item in db.Filmler)
            {
                dgvFilmler.Rows.Add(item.Id, item.Ad,item.Yil,item.imdbPuani,item.Tur.Id);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = dgvFilmler.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex >= 0)
            {
                dgvFilmler.ClearSelection();
                dgvFilmler.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvFilmler, new Point(e.X, e.Y));
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
            FilmEkleGuncelleForm frm = new FilmEkleGuncelleForm(db,id);
            frm.Show();
            this.Close();                   
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
            Film bulunacakFilm = db.Filmler.FirstOrDefault(a => a.Id == id);
            db.Filmler.Remove(bulunacakFilm);
            db.SaveChanges();
            Guncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmEkleGuncelleForm frm = new FilmEkleGuncelleForm(db);
            frm.ShowDialog();
        }
    }
}
