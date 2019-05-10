using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Api_Rest.Startup))]
namespace Api_Rest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
