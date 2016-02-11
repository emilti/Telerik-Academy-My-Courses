

using AutoMapper;
using System;
using TwitterSystem.Api.Infrastructure.Mapping;
using TwitterSystem.Models;

namespace TwitterSystem.Api.Models.Messages
{
    public class MessageViewModel: IMapFrom<Message>, IHaveCustomMappings
    {     
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Message, MessageViewModel>();              
        }
    }
}