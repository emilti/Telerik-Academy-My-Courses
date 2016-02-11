using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSystem.Data;
using TwitterSystem.Models;
using TwitterSystem.Services.Data.Contracts;

namespace TwitterSystem.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IRepository<AppUser> users;

        public UsersService(
            IRepository<AppUser> usersRepo)
        {
            this.users = usersRepo;
        }

        public IQueryable<AppUser> All(int page = 1, int pageSize = 10)
        {            
            return this.users
                 .All()
                .OrderByDescending(g => g.UserName)
                .Skip((page - 1) * 10)
                .Take(10);
        }

        public IQueryable<AppUser> AllSearchedUsers(string userName, int page = 1, int pageSize = 10)
        {
            var result = this.users;
            return this.users
                .All()
                .Where(b => b.UserName.Contains(userName))
                .OrderByDescending(g => g.UserName)
                .Skip((page - 1) * 10)
                .Take(10);
        }

        public AppUser GetUserDetails(string id)
        {
            return this.users.GetById(id);               
        }

        public string GetUserName(string id)
        {
            var user = this.users.GetById(id);
            return user.UserName;
        }
    }
}
