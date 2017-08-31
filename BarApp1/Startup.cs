using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarApp1.Startup))]
namespace BarApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
