using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeWeb.Startup))]
namespace CodeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
