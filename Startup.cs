using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dustin.Startup))]
namespace Dustin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
