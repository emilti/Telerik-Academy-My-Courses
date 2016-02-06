namespace MoviesSystem.ViewModels
{
    using MoviesSystem.Data.Models;
    using System;
    using System.Linq.Expressions;

    public class TitleMovieViewModel
    {
        public static Expression<Func<Movie, TitleMovieViewModel>> FromMovie
        {
            get
            {
                return movie => new TitleMovieViewModel
                {
                    Title = movie.Title,
                };
            }
        }

        public string Title { get; set; }
    }
}