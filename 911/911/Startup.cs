using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_911.Startup))]
namespace _911
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
