namespace TwitterSystem.Api.Controllers
{
    using System.Web.Mvc;
    using Models.Messages;
    using TwitterSystem.Services.Data.Contracts;
    using TwitterSystem.Models;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using App_Start;

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
            List<MessageViewModel> receivedMessagesWithTagToView = new List<MessageViewModel>();
            if (query != string.Empty || query != null)
            {
                var receivedMessagesWithTag = this.messages.GetMessagesWithTag(query);
                receivedMessagesWithTagToView = AutoMapperConfig.Configuration.CreateMapper().Map<List<MessageViewModel>>(receivedMessagesWithTag);              
            }

            return View(receivedMessagesWithTagToView);
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