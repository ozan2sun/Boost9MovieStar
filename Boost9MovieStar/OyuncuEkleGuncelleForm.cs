using AngleSharp.Dom;
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
    public partial class OyuncuEkleGuncelleForm : Form
    {
        private readonly MovieDBContext db;
        private readonly int id;
        
        public OyuncuEkleGuncelleForm(MovieDBContext db)
        {
            InitializeComponent();
            this.db = db;
            
        }
        public OyuncuEkleGuncelleForm(MovieDBContext db, int id)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            btnEkleGuncelle.Text = "Güncelle";
            Oyuncu bulunacakOyuncu = db.Oyuncular.FirstOrDefault(x => x.Id == id);
            IletisimBilgi il = bulunacakOyuncu.IletisimBilgi;
            //1.yol
            //txtAdSoyad.Text = db.Oyuncular.Where(x => x.Id == id).FirstOrDefault().ToString();
            //txtTelefon.Text = db.Oyuncular.Where(x => x.Id == id).FirstOrDefault().IletisimBilgi.Telefon;

            txtAdSoyad.Text = bulunacakOyuncu.AdSoyad;
            if (il == null)
            {
                txtAdres.Text = "Yok";
                txtTelefon.Text = "Yok";
            }
            else
            {
                txtAdres.Text = il.Adres;
                txtTelefon.Text = il.Telefon;
            }
            //boşsa yok yaz doluysa getir yapabilirz
            //ÖDEV
            //if (il.Telefon == DBNull)
            //{
            //    txtTelefon.Text = "Yok";
            //}
            //else
            //{
            //    txtTelefon.Text = il.Telefon;
            //}
        }
        
        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            //oyuncu ekleme
            //oyuncu güncelleme

            Oyuncu oyuncu = new Oyuncu();
            IletisimBilgi il = new IletisimBilgi();
            
            if (btnEkleGuncelle.Text == "Ekle")
            {
                if (string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    MessageBox.Show("Ad boş bırakılamaz");
                }
                else if (string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtTelefon.Text))
                {
                    oyuncu.AdSoyad = txtAdSoyad.Text;

                    il.Telefon = "Yok";
                    il.Adres = "Yok";                   
                }
                else
                {
                    oyuncu.AdSoyad = txtAdSoyad.Text;
                   
                    il.Telefon = txtTelefon.Text;
                    il.Adres = txtAdres.Text;
                    db.Oyuncular.Add(oyuncu);                                  
                }
                db.Oyuncular.Add(oyuncu);
                db.IletisimBilgileri.Add(il);
                db.SaveChanges();
            }
            else
            {
                if (string.IsNullOrEmpty(txtAdSoyad.Text) || string.IsNullOrEmpty(txtTelefon.Text) || string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    MessageBox.Show("Bilgileri tam giriniz");
                }
                else
                {
                    Oyuncu bulunacakOyuncu = db.Oyuncular.FirstOrDefault(a => a.Id == id);
                    bulunacakOyuncu.AdSoyad = txtAdSoyad.Text;

                    IletisimBilgi bulunacakIletisimBilgi = db.IletisimBilgileri.FirstOrDefault(a => a.OyuncuId == id);
                    bulunacakIletisimBilgi.Adres = txtAdres.Text;
                    bulunacakIletisimBilgi.Telefon = txtTelefon.Text;                   
                    db.SaveChanges();                    
                }
               
            }
        }
    }
}
