namespace TwitterSystem.Api.Models.Account
{
    using System;
    using AutoMapper;
    using TwitterSystem.Api.Infrastructure.Mapping;
    using TwitterSystem.Models;

    public class AccountNameViewModel : IMapFrom<AppUser>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<AppUser, AccountNameViewModel>();
        }       
    }
}