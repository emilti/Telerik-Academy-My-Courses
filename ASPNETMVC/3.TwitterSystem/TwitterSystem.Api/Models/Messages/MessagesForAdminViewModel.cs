using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TwitterSystem.Api.Infrastructure.Mapping;
using TwitterSystem.Models;

namespace TwitterSystem.Api.Models.Messages
{
    public class MessagesForAdminViewModel: IMapFrom<Message>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }        

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Message, MessagesForAdminViewModel>();
        }
    }
}