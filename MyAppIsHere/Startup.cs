using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAppIsHere.Startup))]
namespace MyAppIsHere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
