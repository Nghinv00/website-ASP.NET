using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_cafe_film.Startup))]
namespace Web_cafe_film
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
