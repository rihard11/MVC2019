using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdresarAdresarWcfService.Startup))]
namespace AdresarAdresarWcfService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
