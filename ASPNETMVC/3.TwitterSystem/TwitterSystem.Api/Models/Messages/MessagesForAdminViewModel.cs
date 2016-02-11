using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TwitterSystem.Api.Infrastructure.Mapping;
using TwitterSystem.Models;
using TwitterSystem.Services.Data.Contracts;

namespace TwitterSystem.Api.Models.Messages
{
    public class MessagesForAdminViewModel: IMapFrom<Message>, IHaveCustomMappings
    {
       // private readonly IUsersService users;

        public MessagesForAdminViewModel()
        {

        }
        
      //   public MessagesForAdminViewModel(IUsersService usersService)
      //   {
      //       this.users = usersService;
      //   }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string CreatedOn { get; set; }

        public string AuthorId { get; set; }

        public string Author { get; set; }


        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Message, MessagesForAdminViewModel>();
            //  .ForMember(Author, opt => opt.MapFrom(x => this.users.GetUserName(AuthorId)));           
                
        }
    }
}