using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TennisScheduleMvc.Startup))]
namespace TennisScheduleMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
