using Boost9MovieStar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boost9MovieStar.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("name=MovieDBContext") 
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyuncu>().HasOptional(x => x.IletisimBilgi).WithRequired(x => x.Oyuncu);

            modelBuilder.Entity<Film>().Property(x => x.imdbPuani).HasPrecision(2, 1);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<IletisimBilgi> IletisimBilgileri { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Tur> Turler { get; set; }

    }
}

