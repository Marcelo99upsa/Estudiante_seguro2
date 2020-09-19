using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admstudentSecurity.Startup))]
namespace admstudentSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
