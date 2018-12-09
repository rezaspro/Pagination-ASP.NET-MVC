using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginationTest.Startup))]
namespace PaginationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
