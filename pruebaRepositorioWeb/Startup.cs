using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pruebaRepositorioWeb.Startup))]
namespace pruebaRepositorioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
