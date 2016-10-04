using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quiz.WebApp.Startup))]
namespace Quiz.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
