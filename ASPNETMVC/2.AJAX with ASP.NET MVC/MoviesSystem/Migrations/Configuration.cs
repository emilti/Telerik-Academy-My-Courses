namespace MoviesSystem.Migrations
{
    using Models;
    using Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MoviesDbContext context)
        {
            if (context.Movies.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                Movie newMovie = new Movie
                {
                    Title = "Title" + i,
                    Director = "Director" + i,
                    Year = 1990 + i,
                    LeadingMaleRole = "Actor" + i,
                    LeadingMaleRoleAge = 40 + i,
                    LeadingFemaleRole = "Actress" + i,
                    LeadingFemaleRoleAge = 30 + i,
                    Studio = "Studio" + i,
                    StudioAddress = "StudioAdress" + i
                };

                context.Movies.Add(newMovie);
            }

            context.SaveChanges();
        }
    }
}
