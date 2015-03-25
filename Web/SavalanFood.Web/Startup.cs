using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SavalanFood.Web.Startup))]
namespace SavalanFood.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
