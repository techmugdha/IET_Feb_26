using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _08Demo_Filters_Session.Filters
{
    public class MaterUIResultFilter:ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                (context.Result as ViewResult).ViewData["Layout"] = "_MasterPage";
            }
            else
            {
                (context.Result as ViewResult).ViewData["Layout"] = "_Layout";
            }
        }
    }
}
