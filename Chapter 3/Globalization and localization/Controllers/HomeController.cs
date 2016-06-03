using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globalization_and_localization.Controllers
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

        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string language;

            var result = filterContext.Controller.ValueProvider.GetValue("language");

            if (result != null)
            {
                language = result.AttemptedValue;
                System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);

                HttpCookie cookie = new HttpCookie("Language");
                cookie.Value = language;
                Response.Cookies.Add(cookie);
            }
            base.OnActionExecuting(filterContext);
        }
    }
}