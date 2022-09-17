using Boost9MovieStar.Data;
using Boost9MovieStar.DTOs;
using Boost9MovieStar.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boost9MovieStar
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await VerileriYukle();
            Application.Run(new MainForm());

        }

        static async Task VerileriYukle()

        {

            MovieDBContext db = new MovieDBContext();
            if (!db.Filmler.Any())
            {
                #region Adim1
                //Yukarıya async ve task ekledik. void i kaldırdık.
                //1.Adım imdb.com sitesindeki filmId leri okuma.
                List<string> filmIds = new List<string>();
                string url = "https://www.imdb.com/search/title/?groups=top_250&sort=user_rating";
                //web parse işlemi. NugGet tan HtmlAgilityPack yüklenir.
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNodeCollection films = doc.DocumentNode.SelectNodes("//div[@data-tconst]");//XPATH
                foreach (HtmlNode film in films)
                {
                    filmIds.Add(film.Attributes["data-tconst"].Value);
                }
                #endregion

                #region Adim2
                //2.Adım omdbApi'ye bu Id lere göre istek atma ve gelen veriyi istediğimiz şekilde alma.
                //https://www.omdbapi.com/?apikey=1a3394c1&i=tt3896198
                List<MovieDTO> movies = new List<MovieDTO>();
                string apiUrl = "https://www.omdbapi.com/?apikey=1a3394c1&i=";
                HttpClient httpClient = new HttpClient();
                foreach (string filmId in filmIds)
                {
                    HttpResponseMessage result = await httpClient.GetAsync(apiUrl + filmId);
                    if (result.IsSuccessStatusCode)
                    {
                        //Microsoft.Aspnet.WebApi.Client indirdik nugget tan.
                        //string okumak yerine class olarak okumak için.
                        movies.Add(await result.Content.ReadAsAsync<MovieDTO>());
                        //dto => data transfer object.
                    }
                }
                #endregion


                foreach (MovieDTO movie in movies)
                {
                    Film film = new Film()
                    {
                        Ad = movie.Title,
                        imdbID=movie.imdbID,
                        imdbPuani = movie.imdbRating,
                        Yil=movie.Year,
                        Poster=movie.Poster

                    };
                    string genreAd = movie.Genre.Split(',')[0].Trim();
                    Tur tur = db.Turler.FirstOrDefault(x => x.Ad == genreAd);
                    if (tur !=null)
                    {
                        film.Tur = tur;
                    }
                    else
                    {
                        film.Tur = new Tur()
                        {
                            Ad = genreAd
                        };

                    }
                    List<string> oyuncular = movie.Actors.Split(',').ToList();
                    foreach (var item in oyuncular)
                    {
                        Oyuncu oyuncu = db.Oyuncular.FirstOrDefault(x => x.AdSoyad == item.Trim());
                        if (oyuncu !=null)
                        {
                            film.Oyuncular.Add(oyuncu);
                        }
                        else
                        {
                            film.Oyuncular.Add(new Oyuncu
                            {
                                AdSoyad = item.Trim()
                            }) ;
                        }
                    }

                    db.Filmler.Add(film);
                   await db.SaveChangesAsync();//kaydetme işleminin bitmesini bekletiyorum.
                }
            }

        }
    }
}
