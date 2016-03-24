using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2016_03_24_Project1.Startup))]
namespace _2016_03_24_Project1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
