using Boost9MovieStar.Data;
using Boost9MovieStar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boost9MovieStar
{
    public partial class TurEkleForm : Form
    {
        private readonly MovieDBContext db;
        

        public TurEkleForm(MovieDBContext db)
        {
            InitializeComponent();
            this.db = db;
            Guncelle();

        }      

        public void Guncelle()
        {
            dgvTurler.Rows.Clear();
            foreach (var item in db.Turler)
            {
                dgvTurler.Rows.Add(item.Id, item.Ad);
            }
        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTur.Text))
            {
                MessageBox.Show("Boş bırakılamaz");
            }
            else if (btnTurEkle.Text == "Güncelle")
            {
                int id = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
                Tur bulunacakTur = db.Turler.FirstOrDefault(a => a.Id == id);
                bulunacakTur.Ad = txtTur.Text;
                db.SaveChanges();
                Guncelle();
            }
            else
            {                
                Tur bulunacakTur = new Tur();
                bulunacakTur.Id = 10;
                bulunacakTur.Ad = txtTur.Text;
                db.Turler.Add(bulunacakTur);
                db.SaveChanges();
                Guncelle();
            }                      
        }
        

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            btnTurEkle.Text = "Güncelle";
            int id = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
            Tur bulunacakTur = db.Turler.FirstOrDefault(a => a.Id == id);
            txtTur.Text = bulunacakTur.Ad;
        }

        private void dgvTurler_MouseDown_1(object sender, MouseEventArgs e)
        {
            var hti = dgvTurler.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex >= 0)
            {
                dgvTurler.ClearSelection();
                dgvTurler.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvTurler, new Point(e.X, e.Y));
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTurler.SelectedRows[0].Cells[0].Value;
            Tur bulunacakTur = db.Turler.FirstOrDefault(a => a.Id == id);          
            db.Turler.Remove(bulunacakTur);
            db.SaveChanges();
            Guncelle();
        }       
    }
}
