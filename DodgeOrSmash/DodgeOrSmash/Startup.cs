using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DodgeOrSmash.Startup))]
namespace DodgeOrSmash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
