using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHR.Web.Startup))]
namespace MyHR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
