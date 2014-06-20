using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GregsList06202014.Startup))]
namespace GregsList06202014
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
