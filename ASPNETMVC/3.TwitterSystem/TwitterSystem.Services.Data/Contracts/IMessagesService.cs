using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterSystem.Models;

namespace TwitterSystem.Services.Data.Contracts
{

    public interface IMessagesService
    {
        IQueryable<Message> All(int page = 1, int pageSize = 10);

        Message Add(string title, string content, string userId);

        IQueryable<Message> GetMessagesForUser(string Username);

        IQueryable<Message> GetMessagesWithTag(string query);
    }

}
