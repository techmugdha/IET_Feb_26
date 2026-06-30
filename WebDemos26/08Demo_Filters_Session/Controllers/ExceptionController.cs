using Microsoft.AspNetCore.Mvc;

namespace _08Demo_Filters_Session.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
