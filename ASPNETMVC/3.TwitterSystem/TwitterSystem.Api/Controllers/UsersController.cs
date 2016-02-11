namespace TwitterSystem.Api.Controllers
{
    using System.Web.Mvc;
    using Services.Data.Contracts;
    using TwitterSystem.Models;
    using System.Collections.Generic;
    using Models.Messages;
    using AutoMapper.QueryableExtensions;
    using System.Linq;
    using App_Start;

    public class UsersController : Controller
    {
        private readonly IUsersService users;
        private readonly IMessagesService messages;

        public UsersController(IUsersService usersService, IMessagesService messagesService)
        {
            this.users = usersService;
            this.messages = messagesService;
        }

        public ActionResult UserMessages(string Id)
        {
            List<MessageViewModel> receivedMessagesForUserToView = new List<MessageViewModel>();
            AppUser foundUser = this.users.GetUserDetails(Id);
            var receivedMessagesForUser = this.messages.GetMessagesForUser(foundUser.UserName);            
            receivedMessagesForUserToView = AutoMapperConfig.Configuration.CreateMapper().Map<List<MessageViewModel>>(receivedMessagesForUser);          
            return View(receivedMessagesForUserToView);
        }
    }
}