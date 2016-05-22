using Design_and_implement_MVC_controllers.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_and_implement_MVC_controllers.Controllers
{
  //  [ProfileActionAttribute]
    public class SamplesController : Controller
    {
        // GET: Samples
        public ActionResult Index()
        {
            ViewBag.Message = "This is from index";
            var model = DateTime.Now;

            return View(model);
        }

        //[ChildActionOnly]
        public PartialViewResult MyDateTime()
        {
            ViewBag.Message = "This is from myDateTime()";

            var model = DateTime.Now;

            return PartialView(model);
        }
        //[HandleError]
       //  [HandleError(View = "OtherError", ExceptionType = typeof(System.NotImplementedException))]
        public ActionResult HandleError()
        {
            // throw new Exception("Fake an error.");
            // throw new NotImplementedException("Not yet implemented.");
            throw new ArgumentNullException("Test");
            return View();
        }

        public ActionResult ShowError()
        {
            ViewBag.Message = Session["ErrorMessage"];
            return View();
        }

        [ProfileActionAttribute]
        public ActionResult ProfileActionFilter()
        {
            return View();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            // Do some exception logging ....

            if (filterContext.ExceptionHandled)
            {
                return;
            }
           
            filterContext.ExceptionHandled = true;
            Session["ErrorMessage"] = "An exception has occured";
            filterContext.Result = this.RedirectToAction("ShowError", "Samples");


             base.OnException(filterContext);
        }
    }
}