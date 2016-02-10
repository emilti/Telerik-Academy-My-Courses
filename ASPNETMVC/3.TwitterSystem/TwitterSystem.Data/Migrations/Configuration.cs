namespace TwitterSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Common;

    public sealed class Configuration : DbMigrationsConfiguration<TwitterSystemDbContext>
    {

        private UserManager<AppUser> userManager;
        private IRandomGenerator random;
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            this.random = new RandomGenerator();
        }

        protected override void Seed(TwitterSystemDbContext context)
        {
            // this.userManager = new UserManager<AppUser>(new UserStore<AppUser>(context));
            var userManager = new UserManager<AppUser>(new UserStore<AppUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));



            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Regular" });
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Employer" });
            }


            var adminUser = userManager.Users.FirstOrDefault(x => x.Email == "admin@gmail.com");


            if (adminUser == null)
            {
                var admin = new AppUser
                {
                    Email = "admin@gmail.com",
                    UserName = "admin@gmail.com",
                    EmailConfirmed = true                   
                };


                userManager.Create(admin, "123456qwerty");
                userManager.AddToRole(admin.Id, "Admin");
            }


            if (userManager.Users.FirstOrDefault(x => x.Email == "user1@mail.com") == null)
            {
                var user = new AppUser
                {
                    Email = "user1@mail.com",
                    UserName = "user1@mail.com"
                };


                userManager.Create(user, "123456");
                userManager.AddToRole(user.Id, "Regular");
            }


            if (userManager.Users.FirstOrDefault(x => x.Email == "user2@mail.com") == null)
            {
                var user = new AppUser
                {
                    Email = "user2@mail.com",
                    UserName = "user2@mail.com"
                };


                userManager.Create(user, "123456");
                userManager.AddToRole(user.Id, "Regular");
            }


            if (userManager.Users.FirstOrDefault(x => x.Email == "user3@mail.com") == null)
            {
                var user = new AppUser
                {
                    Email = "user3@mail.com",
                    UserName = "user3@mail.com"
                };


                userManager.Create(user, "123456");
                userManager.AddToRoles(user.Id, "Regular", "Admin");
            }


            if (userManager.Users.FirstOrDefault(x => x.Email == "user4@mail.com") == null)
            {
                var user = new AppUser
                {
                    Email = "user4@mail.com",
                    UserName = "user4@mail.com"
                };


                userManager.Create(user, "123456");
                userManager.AddToRole(user.Id, "Regular");
            }


            adminUser = userManager.Users.FirstOrDefault(x => x.Email == "admin@gmail.com");


            if (adminUser != null)
            {
                userManager.AddToRoles(adminUser.Id, "Regular", "Admin", "Employer");
            }


                var allUsers = context.Users.AsQueryable();
                       

                context.SaveChanges();


                // this.SeedRoles(context, roleManager);
                // this.SeedUsers(context);
                this.SeedTwits(context);
            }

        private void SeedRoles(TwitterSystemDbContext context, RoleManager<IdentityRole> roleManager)
        {

            roleManager.Create(new IdentityRole { Name = "User" });
            roleManager.Create(new IdentityRole { Name = "Admin" });         



            // context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            // context.SaveChanges();
        }

        private void SeedUsers(TwitterSystemDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                var user = new AppUser
                {
                    Email = string.Format("{0}@{1}.com", "User" + i, "mail"),
                    UserName = "User" + i
                };

                this.userManager.Create(user, "123456");
            }

            var adminUser = new AppUser
            {
                Email = "admin@mysite.com",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "admin123456");
            this.userManager.AddToRole(adminUser.Id, GlobalConstants.AdminRole);
        }

        private void SeedTwits(TwitterSystemDbContext context)
        {
            if (context.Messages.Any())
            {
                return;
            }

            var users = context.Users.Take(10).ToList();
            for (int j = 0; j < 10; j++)
            {
                var message = new Message
                {
                    Author = users[this.random.RandomNumber(0, users.Count - 1)],
                    Title = this.random.RandomString(2, 20),
                    Content = this.random.RandomString(2, 150),
                    CreatedOn = DateTime.Now
                };

                context.Messages.Add(message);
            }

            context.SaveChanges();
        }
    }
}
