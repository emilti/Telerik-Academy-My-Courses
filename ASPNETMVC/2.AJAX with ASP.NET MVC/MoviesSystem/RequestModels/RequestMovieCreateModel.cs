namespace MoviesSystem.RequestModels
{
    using MoviesSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class RequestMovieCreateModel
    {
        public static Expression<Func<Movie, RequestMovieCreateModel>> FromMovie
        {
            get
            {
                return movie => new RequestMovieCreateModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Director = movie.Director,
                    Year = movie.Year,
                    LeadingMaleRole = movie.LeadingMaleRole,
                    LeadingMaleRoleAge = movie.LeadingMaleRoleAge,
                    LeadingFemaleRole = movie.LeadingFemaleRole,
                    LeadingFemaleRoleAge = movie.LeadingFemaleRoleAge,
                    Studio = movie.Studio,
                    StudioAddress = movie.StudioAddress
                };
            }
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }

        public string LeadingMaleRole { get; set; }

        public int LeadingMaleRoleAge { get; set; }

        public string LeadingFemaleRole { get; set; }

        public int LeadingFemaleRoleAge { get; set; }

        public string Studio { get; set; }

        public string StudioAddress { get; set; }
    }
}