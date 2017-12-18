using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tourcy1.Startup))]
namespace Tourcy1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
