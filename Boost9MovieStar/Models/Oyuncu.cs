using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boost9MovieStar.Models
{
    [Table("Oyuncular")]
    public class Oyuncu
    {
        public Oyuncu()
        {
            Filmler = new List<Film>();
        }
        public int Id { get; set; }

        [Required, MaxLength(60)]  
        public string AdSoyad { get; set; }

        public IletisimBilgi IletisimBilgi { get; set; }


        public List<Film>Filmler { get; set; }

        public override string ToString()
        {
            return $"{AdSoyad}";
        }
    }
}
