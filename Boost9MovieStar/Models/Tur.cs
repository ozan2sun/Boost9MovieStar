using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boost9MovieStar.Models
{
    [Table("Turler")]
    public class Tur
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Ad { get; set; }

        public List<Film>Filmler { get; set; }

    }
}
