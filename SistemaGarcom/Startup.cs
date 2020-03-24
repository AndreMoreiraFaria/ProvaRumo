using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaGarcom.Startup))]
namespace SistemaGarcom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
