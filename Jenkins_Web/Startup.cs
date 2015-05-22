using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jenkins_Web.Startup))]
namespace Jenkins_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
