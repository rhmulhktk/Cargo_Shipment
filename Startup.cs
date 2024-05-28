using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cargo_Shipment.Startup))]
namespace Cargo_Shipment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
