using System.Web;
using System.Web.Mvc;

namespace BikeRental_XX_InventoryManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
