using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieWebClient.Startup))]
namespace MovieWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
