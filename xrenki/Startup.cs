using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xrenki.Startup))]
namespace xrenki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
