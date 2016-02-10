namespace TwitterSystem.Api.Controllers
{
    using System.Web.Mvc;
    using Models.Messages;
    using TwitterSystem.Services.Data.Contracts;
    using TwitterSystem.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;

    public class MessagesController : Controller
    {
        private readonly IMessagesService messages;
        private readonly IUsersService users;
        public ICacheService Cache { get; set; }
        public MessagesController(IMessagesService messagesService, IUsersService usersService)
        {
            this.messages = messagesService;
            this.users = usersService;
        }

        // GET: Messages/WriteMessage
        public ActionResult WriteMessage()
        {
            return View();
        }

        public ActionResult SearchTag(string query)
        {
            List<MessageViewModel> foundMessages = new List<MessageViewModel>();
            if (query != string.Empty || query != null)
            {
                var receivedMessagesWithTag = this.messages.GetMessagesWithTag(query);
                foreach (var item in receivedMessagesWithTag)
                {
                    MessageViewModel newMessage = new MessageViewModel
                    {
                        Title = item.Title,
                        Content = item.Content
                    };

                    foundMessages.Add(newMessage);
                }
            }

            return View(foundMessages);
        }

        [HttpPost]
        public ActionResult WriteMessage(RequestWriteMessageModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Message title is invlaid.");
                return View(model);
            }

            var message = this.messages.Add(model.Title, model.Content, User.Identity.GetUserId());
            return RedirectToAction("Index", "Home");
        }
    }
}