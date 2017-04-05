using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTemplate1.Startup))]
namespace MVCTemplate1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
