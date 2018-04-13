using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSRSEmailForm.Startup))]
namespace SSRSEmailForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
