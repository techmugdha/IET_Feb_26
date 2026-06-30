using System.Diagnostics;
using _08Demo_Filters_Session.Filters;
using _08Demo_Filters_Session.Models;
using Microsoft.AspNetCore.Mvc;

namespace _08Demo_Filters_Session.Controllers
{
    //[LogFilter]
    //[AuthFilter]
    //[MaterUIResultFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
