using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Globlamantics.Web.Startup))]
namespace Globlamantics.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
