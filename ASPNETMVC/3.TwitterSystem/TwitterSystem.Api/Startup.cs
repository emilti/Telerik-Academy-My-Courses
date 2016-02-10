using Microsoft.Owin;
using Owin;
using System.Reflection;
using TwitterSystem.Api.App_Start;

[assembly: OwinStartupAttribute(typeof(TwitterSystem.Api.Startup))]
namespace TwitterSystem.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            DatabaseConfig.Initialize();
            AutoMapperConfig.RegisterMappings(Assembly.Load("TwitterSystem.Api"));
            ConfigureAuth(app);
        }
    }
}
