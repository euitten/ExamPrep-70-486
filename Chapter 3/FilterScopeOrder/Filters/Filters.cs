using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterScopeAndOrder.Filters
{
    public class AuthorizationFilterA : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<div>OnAuthorization : AuthorizationFilterA (Order 2) : Global");
        }
    }

    public class AuthorizationFilterB : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<div>OnAuthorization : AuthorizationFilterB (Order 1) : Action");
        }
    }

    public class AuthorizationFilterC : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<div>OnAuthorization : AuthorizationFilterC (No order) : Global");
        }
    }
}