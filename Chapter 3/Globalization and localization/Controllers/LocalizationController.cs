using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plan_for_SEO_and_accessibility.Controllers
{
    public class LocalizationController : Controller
    {
        // GET: Localization
        public ActionResult SimpleLocalization()
        {
            return View();
        }

        public ActionResult SimpleGlobalization()
        {
            return View();
        }
    }
}