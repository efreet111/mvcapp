using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcapp.Startup))]
namespace mvcapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
