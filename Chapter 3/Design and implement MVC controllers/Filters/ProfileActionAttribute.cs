using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_and_implement_MVC_controllers.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =true, Inherited =false)]
     public class ProfileActionAttribute: ActionFilterAttribute
        {
        private Stopwatch timer;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();

            filterContext.HttpContext.Response.Write(
               string.Format("<div>Action started: {0}</div>",
               DateTime.Now));
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write(
                string.Format("<div>Action method elapsed time: {0}</div>",
                timer.Elapsed.TotalSeconds));
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            // base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write(
              "<div>OnResultExecuted</div>");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
  "<div>OnResultExecuting</div>");
            // base.OnResultExecuting(filterContext);
        }

        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    // not yet implemented
        //}
    }
}