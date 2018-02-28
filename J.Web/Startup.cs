using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(J.Web.Startup))]
namespace J.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
