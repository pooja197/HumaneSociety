using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HumaneSocietyPets.Startup))]
namespace HumaneSocietyPets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
