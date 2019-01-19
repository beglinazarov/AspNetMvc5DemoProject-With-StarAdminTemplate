using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ktys.MvcWebUI.Startup))]
namespace Ktys.MvcWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
