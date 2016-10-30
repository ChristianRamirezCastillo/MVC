using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CR.Web.Startup))]
namespace CR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
