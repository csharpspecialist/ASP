using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageLifeCycle.Startup))]
namespace PageLifeCycle
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
