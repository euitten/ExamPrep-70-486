using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_and_implement_MVC_controllers.Controllers
{
    //  [Authorize(Roles ="Admin")]
    // [RequireHttps]
    public class HomeController : Controller
    {
      // [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult MyDateTime()
        {
            ViewBag.Message = "This is from MyDateTime()";
            var model = DateTime.Now;
            return PartialView(model);
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