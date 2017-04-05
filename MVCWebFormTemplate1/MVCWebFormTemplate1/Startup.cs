using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCWebFormTemplate1.Startup))]
namespace MVCWebFormTemplate1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
