using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Basic.Startup))]
namespace Basic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
