using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Globalization_and_localization.Controllers
{
    public class CustomGlobalizationController : Controller
    {
        // GET: CustomGlobalization
        public ActionResult Index()
        {
            return View();
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var viewResult = filterContext.Result as ViewResult;

            if (viewResult != null)
            {
                var razorEngine = viewResult.ViewEngineCollection.OfType<RazorViewEngine>().Single();
                var viewName = !String.IsNullOrEmpty(viewResult.ViewName) ? viewResult.ViewName : filterContext.RouteData.Values["action"].ToString();
                var razorView = razorEngine.FindView(filterContext.Controller.ControllerContext,viewName, viewResult.MasterName, false).View as RazorView;
                var currentPath = razorView.ViewPath;
                var newPath = currentPath.Replace(viewName, @"en-GB/" + viewName );
                viewResult.View = new RazorView(filterContext.Controller.ControllerContext, newPath, razorView.LayoutPath, razorView.RunViewStartPages, razorView.ViewStartFileExtensions);
            }

            //            base.OnResultExecuting(filterContext);
            base.OnActionExecuted(filterContext);
        }
    }



}

