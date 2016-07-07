using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoundManage.Startup))]
namespace SoundManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
