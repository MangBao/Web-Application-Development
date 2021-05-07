using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestADMIN.Startup))]
namespace TestADMIN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
