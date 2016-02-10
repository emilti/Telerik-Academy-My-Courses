using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterSystem.Api.Models.Account;
using TwitterSystem.Services.Data.Contracts;

namespace TwitterSystem.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService users;

        public HomeController(IUsersService usersService)
        {
            this.users = usersService;
        }

        public ActionResult Index(string query)
        {
            List<AccountNameViewModel> foundUsers = new List<AccountNameViewModel>();
            if (query != string.Empty || query != null)
            {             
                foundUsers = this.users.AllSearchedUsers(query).ProjectTo<AccountNameViewModel>().ToList();
            }
            
            return this.View(foundUsers);
        }   
    }
}