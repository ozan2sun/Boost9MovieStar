using Boost9MovieStar.Data;
using System.Data.Entity;
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
    public partial class OyuncularForm : Form
    {
        private readonly MovieDBContext db;
        

        //1.görev verileri bu forma taşı
        //2.görev oyuncularıListele doldurun.Çekilen veriler dgv ye aktarılacak
        public OyuncularForm(MovieDBContext db)
        {
            InitializeComponent();
            this.db = db;           
            OyunculariListele();
        }    
        
        public void OyunculariListele()
        {
            dgvOyuncular.Rows.Clear();
            foreach (var item in db.Oyuncular.Include(a=>a.IletisimBilgi))
            {
                //using System.Data.Entity; include içinde lambda expression kullanmak için yukarıya el ile ekledik
                if (item.IletisimBilgi != null)
                {
                    dgvOyuncular.Rows.Add(item.Id, item.AdSoyad, item.IletisimBilgi.Adres, item.IletisimBilgi.Telefon);
                }
                else
                {
                    dgvOyuncular.Rows.Add(item.Id, item.AdSoyad, "Yok", "Yok");
                }
            }

        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            //ekleguncelle form açılsın verileri gönderin
            //listeleme methodunu çağırın.
            OyuncuEkleGuncelleForm frm = new OyuncuEkleGuncelleForm(db);           
            frm.ShowDialog();           
            OyunculariListele();
        }
   

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //seçili oyuncu silinecek. Ödev(id si bulunmalı)
            int id = (int)dgvOyuncular.SelectedRows[0].Cells[0].Value;
            Oyuncu bulunacakOyuncu = db.Oyuncular.FirstOrDefault(x => x.Id == id);
            db.Oyuncular.Remove(bulunacakOyuncu);
            db.SaveChanges();
            OyunculariListele();
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo
            //seçili oyuncuyu alıp oyuncuGuncelle formuna atacağım. db.id göndereceğim
            //oyuncugüncelle formunun 2 ctor olacak.
            int id = (int)dgvOyuncular.SelectedRows[0].Cells[0].Value;
            OyuncuEkleGuncelleForm oyuncuEkleGuncelleForm = new OyuncuEkleGuncelleForm(db,id);
            oyuncuEkleGuncelleForm.ShowDialog();
        }

        private void dgvOyuncular_MouseDown(object sender, MouseEventArgs e)
        {
            //eğer sağ click olduysa context menu strip açılsın.
            var hti = dgvOyuncular.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex>=0)
            {
                dgvOyuncular.ClearSelection();
                dgvOyuncular.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvOyuncular, new Point(e.X, e.Y));
            }
        }
    }
}
