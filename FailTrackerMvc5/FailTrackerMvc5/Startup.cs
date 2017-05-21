using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FailTrackerMvc5.Startup))]
namespace FailTrackerMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
