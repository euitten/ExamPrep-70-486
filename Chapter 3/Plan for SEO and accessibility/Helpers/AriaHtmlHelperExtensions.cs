using System;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

public static class AriaHtmlHelperExtensions
{
    public static IHtmlString AriaTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> expression)
    {
        ModelMetadata metadata =
             ModelMetadata.FromLambdaExpression(expression, html.ViewData);
        bool required = metadata.IsRequired;
        RouteValueDictionary attributes = new RouteValueDictionary();
        if (required)
            attributes.Add("aria-required", true);
        return html.TextBoxFor(expression, attributes);
    }
}
