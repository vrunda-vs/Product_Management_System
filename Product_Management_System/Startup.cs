using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Product_Management_System.Startup))]
namespace Product_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
