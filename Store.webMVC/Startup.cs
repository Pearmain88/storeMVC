using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store.webMVC.Startup))]
namespace Store.webMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
