using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plan_for_SEO_and_accessibility.Controllers
{
    public class GlobalizationController : Controller
    {
        // GET: Localization
        public ActionResult SimpleLocalization()
        {
            return View();
        }

        public ActionResult SimpleGlobalization()
        {
            ViewData["CurrentUICulture"] = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            ViewData["CurrentCulture"] =  System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            return View();
        }

        //public ActionResult RazorLocalization()
        //{
        //    return View();
        //}

        public ActionResult RazorLocalization(string language)
        {
            if (language != null)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);

                HttpCookie cookie = new HttpCookie("Language");
                cookie.Value = language;
                Response.Cookies.Add(cookie);
            }

            return View();
        }

        [HttpPost]
        public ActionResult RazorLocalization(Globalization_and_localization.Models.Player player)
        {
            if (ModelState.IsValid)
            {
                return View(player);
            }
            else {
                return View();
            }

        }

        public ActionResult GlobalizeWithJQuery()
        {
            return View();
        }
    }
}