using _08Demo_Filters_Session.Loggers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _08Demo_Filters_Session.Filters
{
    //public class LogFilter : Attribute,IActionFilter,IResultFilter
    public class LogFilter : ActionFilterAttribute
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.CurrentLogger.Log($"{context.HttpContext.Request.Path} is complete\n");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.CurrentLogger.Log($"{context.HttpContext.Request.Path} is being called\n");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Logger.CurrentLogger.Log($"UI is processed now..\n");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Logger.CurrentLogger.Log($"UI is about to get processed...\n");
        }
    }
}
