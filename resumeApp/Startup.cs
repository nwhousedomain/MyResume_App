using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(resumeApp.Startup))]
namespace resumeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
