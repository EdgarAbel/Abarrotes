using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Abarrotes.Startup))]
namespace Abarrotes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
