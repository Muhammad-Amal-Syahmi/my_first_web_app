using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(my_first_web_app.Startup))]
namespace my_first_web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
