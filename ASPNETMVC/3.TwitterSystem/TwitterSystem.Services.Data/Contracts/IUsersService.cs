using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSystem.Models;

namespace TwitterSystem.Services.Data.Contracts
{
    public interface IUsersService
    {
        IQueryable<AppUser> AllSearchedUsers(string userName, int page = 1, int pageSize = 10);

        IQueryable<AppUser> All(int page = 1, int pageSize = 10);

        AppUser GetUserDetails(string id);

        string GetUserName(string id);
    }
}
