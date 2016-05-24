using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterScopeForwardOrderReverseOrder.Filters
{
        public class ActionFilter1 : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnActionExecuting : ActionFilter1 (Scope Global)<div>");
            }

            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnActionExecuted : ActionFilter1 (Scope Global)<div>");
            }

            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnResultExecuting : ActionFilter1 (Scope Global)<div>");
            }

            public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnResultExecuted : ActionFilter1 (Scope Global)<div>");
            }
        }

        public class ActionFilter2 : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnActionExecuting : ActionFilter2 (Scope Controller)<div>");
            }

            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnActionExecuted : ActionFilter2 (Scope Controller)<div>");
            }

            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnResultExecuting : ActionFilter2 (Scope Controller)<div>");
            }

            public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnResultExecuted : ActionFilter2 (Scope Controller)<div>");
            }
        }

        public class ActionFilter3 : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnActionExecuting : ActionFilter3 (Scope Action)<div>");
            }

            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnActionExecuted : ActionFilter3 (Scope Action)<div>");
            }

            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnResultExecuting : ActionFilter3 (Scope Action)<div>");
            }

            public override void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnResultExecuted : ActionFilter3 (Scope Action)<div>");
            }
        }

        public class AuthorizationFilter : AuthorizeAttribute
        {
            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Forward Order - OnAuthorization : AuthorizationFilter (Scope Controller)<div>");
            }
        }


        public class HandleErrorA : HandleErrorAttribute
        {
            public override void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnException : HandleErrorA (Scope Action)<div>");
            }
        }

        public class HandleErrorB : HandleErrorAttribute
        {
            public override void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<div>Reverse Order - OnException : HandleErrorB (Scope Action)<div>");
            }
        }
}