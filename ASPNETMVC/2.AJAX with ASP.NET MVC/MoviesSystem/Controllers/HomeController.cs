using MoviesSystem.Data.Models;
using MoviesSystem.Models;
using MoviesSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesSystem.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDbContext dbContext;

        public HomeController()
        {
            this.dbContext = new MoviesDbContext();
        }

        public ActionResult Index(string query)
        {
            List<MovieViewModel> result = new List<MovieViewModel>();
            if(query != string.Empty)
            {
                result = dbContext.Movies
               .Where(movie => movie.Title.ToLower().Contains(query.ToLower()))
               .Select(MovieViewModel.FromMovie)
               .ToList();
            }else
            {
                result = dbContext.Movies.Select(MovieViewModel.FromMovie).ToList();
            }


            return this.View(result);            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}