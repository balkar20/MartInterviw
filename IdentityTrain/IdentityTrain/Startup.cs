using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityTrain.Startup))]
namespace IdentityTrain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
