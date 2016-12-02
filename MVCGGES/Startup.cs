using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGGES.Startup))]
namespace MVCGGES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
