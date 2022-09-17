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
    public partial class FilmEkleGuncelleForm : Form
    {
        private readonly MovieDBContext db;
        private readonly int id;

        public FilmEkleGuncelleForm(MovieDBContext db)
        {
            InitializeComponent();
            this.db = db;
            CmbDoldur();
        }

        private void CmbDoldur()
        {
            cmbTur.Items.Add("Bütün Türler");
            foreach (var item in db.Turler.ToList())
            {
                cmbTur.Items.Add(item);
            }
            cmbTur.DisplayMember = "Ad";
            cmbTur.SelectedIndex = 0;
        }

        public FilmEkleGuncelleForm(MovieDBContext db,int id)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            CmbDoldur();
            btnEkle.Text = "Güncelle";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text=="Güncelle")
            {
                Film bulunacakFilm = db.Filmler.FirstOrDefault(a => a.Id == id);
                bulunacakFilm.Ad = txtFilmAdi.Text;
                bulunacakFilm.Yil = (int)nudYil.Value;
                bulunacakFilm.imdbPuani = nudImdb.Value;
                bulunacakFilm.Poster = txtPoster.Text;
                bulunacakFilm.TurId = cmbTur.SelectedIndex;
                db.SaveChanges();
                this.Close();
            }
            else
            {
                Film film = new Film();
                film.Ad = txtFilmAdi.Text;
                film.Yil = (int)nudYil.Value;
                film.imdbPuani = nudImdb.Value;
                film.Poster = txtPoster.Text;
                film.TurId = cmbTur.SelectedIndex;
                db.Filmler.Add(film);
                db.SaveChanges();
                this.Close();
            }          
        }      
    }
}
