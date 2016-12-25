using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Visitel.Startup))]
namespace Visitel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
