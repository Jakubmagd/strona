using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(strona.Startup))]
namespace strona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
