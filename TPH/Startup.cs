using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPH.Startup))]
namespace TPH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
