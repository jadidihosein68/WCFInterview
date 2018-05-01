using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEBWarmup.Startup))]
namespace SEBWarmup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
