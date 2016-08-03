using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorial.Material.Design.Web.Startup))]
namespace Tutorial.Material.Design.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
