using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSP.Startup))]
namespace WebSP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
