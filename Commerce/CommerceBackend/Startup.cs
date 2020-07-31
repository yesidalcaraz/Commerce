using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommerceBackend.Startup))]
namespace CommerceBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
