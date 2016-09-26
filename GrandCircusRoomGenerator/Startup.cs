using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrandCircusRoomGenerator.Startup))]
namespace GrandCircusRoomGenerator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
