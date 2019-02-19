using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ali.Admin.Startup))]
namespace Ali.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
