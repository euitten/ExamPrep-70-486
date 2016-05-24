using FilterScopeForwardOrderReverseOrder.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterScopeForwardOrderReverseOrder.Controllers
{
    [ActionFilter2]
    public class HomeController : Controller
    {
        [ActionFilter3]
        [AuthorizationFilter]
        [HandleErrorB]
        public ActionResult Index()
        {
            HttpContext.Response.Write("<div>Home Index Action</div>");
          
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}