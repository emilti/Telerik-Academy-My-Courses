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

    public class MessagessService : IMessagesService
    {
        private readonly IRepository<Message> messages;
        private readonly IRepository<AppUser> users;

        public MessagessService(
            IRepository<Message> messagesRepo,
            IRepository<AppUser> usersRepo)
        {
            this.messages = messagesRepo;
            this.users = usersRepo;
        }


        public IQueryable<Message> All(int page = 1, int pageSize = 10)
        {
            var result = this.messages;
            return this.messages
                 .All()
                .OrderByDescending(g => g.CreatedOn)
                .Skip((page - 1) * 10)
                .Take(10);
        }

        public Message Add(string title, string content, string userId)
        {
            AppUser currentUser = this.users
                 .All()
                 .FirstOrDefault(u => u.Id == userId);

            string currentUserUsername = currentUser.UserName;

            var newMessage = new Message
            {
                Title = title,
                Content = content,
                AuthorId = userId,
                CreatedOn = DateTime.UtcNow,
            };

            this.messages.Add(newMessage);
            this.messages.SaveChanges();

            return newMessage;
        }

        public IQueryable<Message> GetMessagesForUser(string Username)
        {
            // var user = this.users.All().FirstOrDefault(b => b.UserName == Username);
            var user = this.users.All().FirstOrDefault(u => u.UserName == Username);
            var messagesForUser = this.messages.All().Where(m => m.AuthorId == user.Id);            
            return messagesForUser;
        }
        public IQueryable<Message> GetMessagesWithTag(string query)
        {
            var messagesWithTag = this.messages.All().Where(m => m.Content.Contains(query));
            return messagesWithTag;
        }
    }
}
