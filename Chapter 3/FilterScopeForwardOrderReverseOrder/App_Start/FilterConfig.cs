using System.Web;
using System.Web.Mvc;

namespace FilterScopeForwardOrderReverseOrder
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalFilters.Filters.Add(new Filters.ActionFilter1());
            GlobalFilters.Filters.Add(new Filters.HandleErrorA());
        }
    }
}
