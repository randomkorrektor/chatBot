using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatBot.Startup))]
namespace chatBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
