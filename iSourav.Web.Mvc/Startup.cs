using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iSourav.Web.Mvc.Startup))]
namespace iSourav.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
