using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boost9MovieStar.Models
{
    [Table("Filmler")]
    public class Film
    {
        public Film()
        {
            Oyuncular = new List<Oyuncu>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Ad { get; set; }

        [Range(1700,2025)]
        public int Yil { get; set; }

        public decimal imdbPuani { get; set; }

        public string Poster { get; set; }

        public string imdbID { get; set; }

        public int? TurId { get; set; }

        public virtual Tur Tur { get; set; }

        public virtual List<Oyuncu> Oyuncular { get; set; }

    }
}
