using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plan_for_SEO_and_accessibility.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Aria()
        {
            ViewBag.Message = "Aria enabled page";

            return View();
        }

        public ActionResult AriaMvc()
        {
            ViewBag.Message = "MVC Aria enabled page";

            return View();
        }

        [HttpPost]
        public ActionResult AriaMvc(Plan_for_SEO_and_accessibility.Models.User user)
        {
            ViewBag.Message = "MVC Aria enabled page";
            if (ModelState.IsValid)
            { return View(user); }
            else
            { return View(); }

        }

    }
}