using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SimpleBlog.WebApp.Startup))]
namespace SimpleBlog.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
