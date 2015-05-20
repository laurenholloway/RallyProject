using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RallyProject.Startup))]
namespace RallyProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
