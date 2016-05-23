using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Design_and_implement_MVC_controllers
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // ModelBinders.Binders.Remove(typeof(Binary));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);      
        
        }
    }
}
