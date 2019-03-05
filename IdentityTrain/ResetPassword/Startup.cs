using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResetPassword.Startup))]
namespace ResetPassword
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
