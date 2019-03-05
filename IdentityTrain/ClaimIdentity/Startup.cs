using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaimIdentity.Startup))]
namespace ClaimIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
