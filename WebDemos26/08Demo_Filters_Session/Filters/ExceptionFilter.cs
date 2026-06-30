using _08Demo_Filters_Session.Loggers;
using Microsoft.AspNetCore.Diagnostics;

namespace _08Demo_Filters_Session.Filters
{
    public class ExceptionFilter:IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            //Log details about any exception occured in MVC life cycle
            Logger.CurrentLogger.Log(exception.Message);
            Logger.CurrentLogger.Log(exception.StackTrace);

            //Tell MVC life cycle to redirect to common UI i.e. Error View
            httpContext.Response.Redirect("/Exception/Error");

            //Tell MVC life cycle that we have handled error.
            //No need for escalating error any further.

            return new ValueTask<bool>(true);
        }
    }
}
