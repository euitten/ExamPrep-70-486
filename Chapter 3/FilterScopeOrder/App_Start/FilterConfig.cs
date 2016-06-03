using FilterScopeAndOrder.Filters;
using System.Web;
using System.Web.Mvc;

namespace FilterScopeOrder
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            GlobalFilters.Filters.Add(new AuthorizationFilterA() { Order = 1 });
            GlobalFilters.Filters.Add(new AuthorizationFilterC());

        }
    }
}
