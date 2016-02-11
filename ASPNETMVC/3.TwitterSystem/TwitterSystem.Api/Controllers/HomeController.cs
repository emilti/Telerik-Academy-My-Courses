using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterSystem.Api.App_Start;
using TwitterSystem.Api.Models.Account;
using TwitterSystem.Models;
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
            List<AppUser> foundUsers = new List<AppUser>();
            List<AccountNameViewModel> foundUsersToView = new List<AccountNameViewModel>();
            if (query != string.Empty && query != null)
            {             
                foundUsers = this.users.AllSearchedUsers(query).ToList();
                foundUsersToView = AutoMapperConfig.Configuration.CreateMapper().Map<List<AccountNameViewModel>>(foundUsers);
            }
            
            return this.View(foundUsersToView);
        }   
    }
}