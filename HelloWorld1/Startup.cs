using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld1.Startup))]
namespace HelloWorld1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
