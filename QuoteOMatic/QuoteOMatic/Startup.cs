using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuoteOMatic.Startup))]
namespace QuoteOMatic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
