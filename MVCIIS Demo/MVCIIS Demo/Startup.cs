using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIIS_Demo.Startup))]
namespace MVCIIS_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
