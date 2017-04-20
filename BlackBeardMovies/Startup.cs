using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackBeardMovies.Startup))]
namespace BlackBeardMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
