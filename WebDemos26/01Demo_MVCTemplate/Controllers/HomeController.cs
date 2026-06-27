using System.Diagnostics;
using _01Demo_MVCTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace _01Demo_MVCTemplate.Controllers
{
    // Controller
    public class HomeController : Controller
    {
        // Action Method
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
