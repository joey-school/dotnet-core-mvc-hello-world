using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;
using System.Collections.Generic;

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
        public string Index()
		{
            //MvcMovieContext db = new MvcMovieContext();

            List<Movie> movies = new List<Movie>();


			Movie movie = new Movie();
			movie.Title = "Avatar";

            movies.Add(movie);

            Movie movie2 = new Movie();
            movie2.Title = "Terminator";

            movies.Add(movie2);

            //ViewModelProfile vmp = new ViewModelProfile();
            //vmp.Person = new Person();//
            //vmp.Movies = movies;


            //return View(vmp);
            return "oiiiiiiii";//View();//
		}

		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hell344333o " + name;
			ViewData["NumTimes"] = numTimes;

			return View();
		}
	}
}