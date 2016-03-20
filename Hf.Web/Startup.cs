using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hf.Web.Startup))]
namespace Hf.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
