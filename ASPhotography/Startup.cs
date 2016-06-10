using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPhotography.Startup))]
namespace ASPhotography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
