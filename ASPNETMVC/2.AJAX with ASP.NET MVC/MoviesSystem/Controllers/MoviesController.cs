using MoviesSystem.Models;
using MoviesSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;
using MoviesSystem.RequestModels;
using MoviesSystem.Data.Models;

namespace MoviesSystem.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesDbContext dbContext;

        public MoviesController()
        {
            this.dbContext = new MoviesDbContext();
        }

        public ActionResult MovieById(int Id)
        {
            MovieFullInfoViewModel movie = dbContext.Movies.Select(MovieFullInfoViewModel.FromMovie).FirstOrDefault(x => x.Id == Id);

            return this.View(movie);
        }

        public ActionResult CreateMovie()
        {
            return View();
        }

        public ActionResult EditMovie(int Id)
        {
            MovieFullInfoViewModel movie = dbContext.Movies.Select(MovieFullInfoViewModel.FromMovie).FirstOrDefault(x => x.Id == Id);

            return this.View(movie);
        }

        public ActionResult DeleteMovie(int Id)
        {
            Movie movie = dbContext.Movies.FirstOrDefault(x => x.Id == Id);
            dbContext.Movies.Remove(movie);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult UpdateForm(int Id, RequestMovieUpdateModel model)
        {
            var item = dbContext.Movies.FirstOrDefault(b => b.Id == Id);
            item.Title = model.Title;
            item.Director = model.Director;
            item.Year = model.Year;
            item.LeadingMaleRole = model.LeadingMaleRole;
            item.LeadingMaleRoleAge = model.LeadingMaleRoleAge;
            item.LeadingFemaleRole = model.LeadingFemaleRole;
            item.LeadingFemaleRoleAge = model.LeadingFemaleRoleAge;
            item.Studio = model.Studio;
            item.StudioAddress = model.StudioAddress;
            dbContext.Movies.AddOrUpdate(item);
            dbContext.SaveChanges();
            return RedirectToAction("MovieById", new { id = Id });
        }

        public ActionResult CreateForm(RequestMovieCreateModel model)
        {
            Movie newMovie = new Movie
            {
                Title = model.Title,
                Director = model.Director,
                Year = model.Year,
                LeadingMaleRole = model.LeadingMaleRole,
                LeadingMaleRoleAge = model.LeadingMaleRoleAge,
                LeadingFemaleRole = model.LeadingFemaleRole,
                LeadingFemaleRoleAge = model.LeadingFemaleRoleAge,
                Studio = model.Studio,
                StudioAddress = model.StudioAddress
            };

            dbContext.Movies.AddOrUpdate(newMovie);
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}