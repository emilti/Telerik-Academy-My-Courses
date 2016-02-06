namespace MoviesSystem.Models
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MoviesSystem.Data.Models;
    using MoviesSystem.Migrations;

    public class MoviesDbContext : IdentityDbContext<AppUser>
    {
        public MoviesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
        }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }

        public IDbSet<Movie> Movies { get; set; }
    }
}