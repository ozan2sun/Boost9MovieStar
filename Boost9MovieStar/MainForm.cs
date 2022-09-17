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
    public partial class MainForm : Form
    {
        MovieDBContext db = new MovieDBContext();
        public MainForm()
        {
            InitializeComponent();
            FilmleriYukle();
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "Id";
            CmbDoldur();
        }

        private void CmbDoldur()
        {
            comboBox1.Items.Add("Bütün Türler");
            foreach (var item in db.Turler.ToList())
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void FilmleriYukle()
        {
            dgvFilmler.Rows.Clear();
            foreach (var item in db.Filmler.ToList())
            {
                dgvFilmler.Rows.Add(item.Id, item.Ad, item.Poster, item.Yil, item.imdbPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
                
            }
        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            //TODO veri taşıyacağız tasarımdan sonra
            
            OyuncularForm frm = new OyuncularForm(db);
            //frm.Show();
            //this.Hide();
            frm.ShowDialog();
        }

        private void dgvFilmler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count>0)
            {
                string posterLinki = (string)dgvFilmler.SelectedRows[0].Cells[2].Value;
                pboFilmPoster.ImageLocation = posterLinki;
            }
        }

        private void tsmiTurler_Click(object sender, EventArgs e)
        {
            TurEkleForm frm = new TurEkleForm(db);
            //this.Hide();
            frm.ShowDialog();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==0)
            {
                dgvFilmler.Rows.Clear();
                foreach (var item in db.Filmler.ToList())
                {
                    dgvFilmler.Rows.Add(item.Id, item.Ad, item.Poster, item.Yil, item.imdbPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
                }
            }
            else
            {
                dgvFilmler.Rows.Clear();
                foreach (var item in db.Filmler.Where(x => x.TurId == comboBox1.SelectedIndex).ToList())
                {
                    dgvFilmler.Rows.Add(item.Id, item.Ad, item.Poster, item.Yil, item.imdbPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvFilmler.Rows.Clear();
            foreach (var item in db.Filmler.Where(x=>x.Ad.StartsWith(textBox1.Text)).ToList())
            {
                dgvFilmler.Rows.Add(item.Id, item.Ad, item.Poster, item.Yil, item.imdbPuani, item.imdbID, item.Tur.Ad, string.Join(",", item.Oyuncular.Select(x => x.AdSoyad)));
            }
        }

        private void tsmiFilmEkle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvFilmler.SelectedRows[0].Cells[0].Value;
            FilmEkle frm = new FilmEkle(db,id);
            frm.ShowDialog();
        }       

        

        //1.görev tsmiOyuncular butonuna basıldığı zaman Oyuncu formu açılsın.
        //2.görev film değiştiğinde poster değişsin
    }
}
