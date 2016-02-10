using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using AutoMapper;
using TwitterSystem.Api.Infrastructure.Mapping;

namespace TwitterSystem.Api.Models.Messages
{
    public class MessageViewModel: IMapFrom<Message>, IHaveCustomMappings
    {     

        public string Title { get; set; }

        public string Content { get; set; }   

        public void CreateMappings(IConfiguration config)
        {
            Mapper.CreateMap<Message, MessageViewModel>();                
        }
    }
}