using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMinhHuy.Startup))]
namespace NguyenMinhHuy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
