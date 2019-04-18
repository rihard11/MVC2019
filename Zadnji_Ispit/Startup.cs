using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zadnji_Ispit.Startup))]
namespace Zadnji_Ispit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
