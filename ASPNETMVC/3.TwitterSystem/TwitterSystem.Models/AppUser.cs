namespace TwitterSystem.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class AppUser : IdentityUser
    {
        private ICollection<Message> messages;

        public AppUser()
        {
            this.Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }

            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
