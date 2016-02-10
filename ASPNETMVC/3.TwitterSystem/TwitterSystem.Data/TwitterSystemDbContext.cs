namespace TwitterSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using TwitterSystem.Models;

    public class TwitterSystemDbContext : IdentityDbContext<AppUser>, ITwitterSystemDbContext
    {
        public TwitterSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterSystemDbContext Create()
        {
            return new TwitterSystemDbContext();
        }

        public virtual IDbSet<Message> Messages { get; set; }
    }
}
