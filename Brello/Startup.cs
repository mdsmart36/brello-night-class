using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Brello.Startup))]
namespace Brello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
