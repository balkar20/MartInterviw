using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaimTrain.Startup))]
namespace CaimTrain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
