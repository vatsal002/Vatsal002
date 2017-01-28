using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TESTMVC.Startup))]
namespace TESTMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
