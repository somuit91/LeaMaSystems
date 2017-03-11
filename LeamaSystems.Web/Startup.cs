using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeamaSystems.Web.Startup))]
namespace LeamaSystems.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
