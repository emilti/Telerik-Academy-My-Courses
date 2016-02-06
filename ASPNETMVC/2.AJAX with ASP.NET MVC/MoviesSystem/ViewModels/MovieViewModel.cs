using MoviesSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MoviesSystem.ViewModels
{
    public class MovieViewModel
    {
        public static Expression<Func<Movie, MovieViewModel>> FromMovie
        {
            get
            {
                return movie => new MovieViewModel
                {
                    Id = movie.Id,
                    Title = movie.Title                                      
                };
            }
        }

        public int Id { get; set; }

        public string Title { get; set; }
    }
}