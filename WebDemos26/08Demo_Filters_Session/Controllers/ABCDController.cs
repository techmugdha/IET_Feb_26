using _08Demo_Filters_Session.Filters;
using Microsoft.AspNetCore.Mvc;

namespace _08Demo_Filters_Session.Controllers
{
    //[LogFilter]
    public class ABCDController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
