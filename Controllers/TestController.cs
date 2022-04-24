using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineCinema_BARS_GROUP.Data.Intarfaces;
using OnlineCinema_BARS_GROUP.Models;

namespace ReactApp.Controllers
{
    public class TestController : ControllerBase
    {
        static List<Movie> data = new List<Movie>
        {
            new Movie()
                    {
                        Name = "Гачи",
                        ShortDesc = "Лучший фильм",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://yt3.ggpht.com/ytc/AKedOLRuzumcGW2icbbTjr7I0AJWKFbq7NAiO05fmQK9vg=s900-c-k-c0x00ffffff-no-rj",
                        Film = "",
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Гачи2",
                        ShortDesc = "Лучший фильм2",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://yt3.ggpht.com/ytc/AKedOLRuzumcGW2icbbTjr7I0AJWKFbq7NAiO05fmQK9vg=s900-c-k-c0x00ffffff-no-rj",
                        Film = "",
                        Time = 500
                    },
                    new Movie()
                    {
                        Name = "Гачи3",
                        ShortDesc = "Лучший фильм3",
                        LongDesc = "Самый лучший фильм",
                        FilmScore = 4.5,
                        Img = "https://yt3.ggpht.com/ytc/AKedOLRuzumcGW2icbbTjr7I0AJWKFbq7NAiO05fmQK9vg=s900-c-k-c0x00ffffff-no-rj",
                        Film = "",
                        Time = 500
                    }
        };
        private readonly IMovie _movie;
        public TestController(IMovie movie)
        {
            _movie = movie;
        }
        public ActionResult Index()
        {
            return new JsonResult(_movie.GetAllMovies);
        }
        public ActionResult GetMovies()
        {
            return new JsonResult(_movie.GetAllMovies);
        }

        [HttpPost]
        public ActionResult AddMovie(Movie movie)
        {
            Random random = new Random();
            movie.Id = random.Next();
            data.Add(movie);
            return new JsonResult(movie);
        }

        [HttpDelete]
        public ActionResult DeleteMovie(int id)
        {
            Movie movie = data.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                data.Remove(movie);
                return new JsonResult(movie);
            }
            return new JsonResult(movie);
        }
    }
}