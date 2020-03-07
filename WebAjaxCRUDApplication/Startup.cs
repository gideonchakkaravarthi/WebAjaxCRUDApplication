using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAjaxCRUDApplication.Startup))]
namespace WebAjaxCRUDApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
