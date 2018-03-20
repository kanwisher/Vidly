using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);

        }

        public ActionResult Details(int id)
        {

            var movies = GetMovies();
            var movie = movies.Find(x => x.Id == id);

            return View(movie);

        }

        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie() {Id = 1, Name = "Flubber"},
                new Movie() {Id = 2, Name = "Space Jam"}
            };

            return movies;

        }

    }
}