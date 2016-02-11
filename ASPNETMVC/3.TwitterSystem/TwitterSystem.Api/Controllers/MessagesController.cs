namespace TwitterSystem.Api.Controllers
{
    using System.Web.Mvc;
    using Models.Messages;
    using Services.Data.Contracts;
    using Microsoft.AspNet.Identity;
    using System.Collections.Generic;
    using Infrastructure.Mapping;
    using System.Linq;
    using App_Start;

    public class MessagesController : Controller
    {
        private readonly IMessagesService messages;
        private readonly IUsersService users;
        private ICacheService Cache;
        public MessagesController(IMessagesService messagesService, IUsersService usersService, ICacheService cacheService)
        {
            this.messages = messagesService;
            this.users = usersService;
            this.Cache = cacheService;
        }

        [HttpGet]
        [Authorize(Roles = "Regular,Admin")]
        public ActionResult WriteMessage()
        {
            return View();
        }

        public ActionResult SearchTag(string query)
        {
            List<MessageViewModel> receivedMessagesWithTagToView = new List<MessageViewModel>();
            if (query != string.Empty && query != null)
            {
                // var receivedMessagesWithTag = this.messages.GetMessagesWithTag(query);

                receivedMessagesWithTagToView =
                this.Cache.Get(
                    "searched" + query,
                    () => this.messages.GetMessagesWithTag(query).To<MessageViewModel>().ToList(),
                    15 * 60);                           
            }

            return View(receivedMessagesWithTagToView);
        }

        [HttpPost]
        [Authorize(Roles = "Regular,Admin")]
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

        [Authorize(Roles = "Admin")]
        public ActionResult GetAllMessages()
        {
            var messages = this.messages.All().ToList();
            var receivedMessagesForAdminToView = AutoMapperConfig.Configuration.CreateMapper().Map<List<MessagesForAdminViewModel>>(messages);            
            return View(receivedMessagesForAdminToView);
        }
    }
}