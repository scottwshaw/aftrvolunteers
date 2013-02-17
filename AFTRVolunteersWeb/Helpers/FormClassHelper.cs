using System.Web.Mvc.Html;

namespace System.Web.Mvc
{
    public static class HtmlHelperExtension
    {
        public static MvcForm BeginFormWithClassName(this HtmlHelper helper, string cssClassName)
        {
            string controllerName = (string)helper.ViewContext.RouteData.Values["controller"];
            string actionName = (string)helper.ViewContext.RouteData.Values["action"];
            return helper.BeginForm(actionName, controllerName, FormMethod.Post, new { @class = cssClassName });
        }
    }
}