using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FicticiousWebBooksellers2.Startup))]
namespace FicticiousWebBooksellers2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
