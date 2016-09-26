using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDemos.Startup))]
namespace MVCDemos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
