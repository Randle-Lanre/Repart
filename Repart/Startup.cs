using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repart.Startup))]
namespace Repart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
