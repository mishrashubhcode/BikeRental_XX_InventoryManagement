using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeRental_XX_InventoryManagement.Startup))]
namespace BikeRental_XX_InventoryManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
