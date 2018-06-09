using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TweeText.Startup))]
namespace TweeText
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
