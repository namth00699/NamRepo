using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NuocMamReal.Startup))]
namespace NuocMamReal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
