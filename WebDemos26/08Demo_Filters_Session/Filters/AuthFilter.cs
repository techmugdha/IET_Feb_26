using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _08Demo_Filters_Session.Filters
{
    public class AuthFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            string isLoggedIn =context.HttpContext.Session.GetString("isLoggedIn");

            if (isLoggedIn == null)
            {
                context.HttpContext.Response.Redirect("/Login/SignIn");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
           //
        }
    }
}
