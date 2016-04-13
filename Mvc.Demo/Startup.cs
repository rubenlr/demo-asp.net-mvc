using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc.Demo.Startup))]
namespace Mvc.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
