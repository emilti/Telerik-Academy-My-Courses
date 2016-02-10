namespace TwitterSystem.Api.Controllers
{
    using System.Web.Mvc;
    using Services.Data.Contracts;
    using TwitterSystem.Models;
    using System.Collections.Generic;
    using Models.Messages;
    using AutoMapper.QueryableExtensions;
    using System.Linq;

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
            List<MessageViewModel> messagesForUser = new List<MessageViewModel>();
            AppUser foundUser = this.users.GetUserDetails(Id);
            var receivedMessagesForUser = this.messages.GetMessagesForUser(foundUser.UserName);
            // .ProjectTo<MessageViewModel>();
            foreach (var item in receivedMessagesForUser)
            {
                MessageViewModel newMessage = new MessageViewModel
                {
                    Title = item.Title,
                    Content = item.Content
                };

                messagesForUser.Add(newMessage);
            }
            messagesForUser = messagesForUser.ToList();
            return View(messagesForUser);
        }
    }
}