using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aksh_project_test.Startup))]
namespace Aksh_project_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
