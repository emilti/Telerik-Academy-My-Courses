namespace TwitterSystem.Api.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using TwitterSystem.Models;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class TwitterSystemDbContext : IdentityDbContext<AppUser>
    {
        public TwitterSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterSystemDbContext Create()
        {
            return new TwitterSystemDbContext();
        }
    }
}