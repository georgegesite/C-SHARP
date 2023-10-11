using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JokesAPp.Startup))]
namespace JokesAPp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
