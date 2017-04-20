using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CiTest2Website.Startup))]
namespace CiTest2Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
