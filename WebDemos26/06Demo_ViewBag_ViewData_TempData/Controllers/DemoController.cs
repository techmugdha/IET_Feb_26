using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace _06Demo_ViewBag_ViewData_TempData.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // dynamic
            // ViewBag dynamic type -- Key : Value based collection which is available between same action method and its view
            // ViewBag internally uses ViewData Collection
            // means e.g : ViewBag.fullname == ViewData["fullname"]
            ViewBag.Title = "Index";
            ViewBag.Number = 123456;

            // ViewData Object type -- Key : Value based collection which is available between same action method and its view
            ViewData["fullname"] = "Peter Bishop";

            string[] names = new string[] { "Peter","Walter","Olivia"};

            ViewBag.Names =  names;

            int[] numbers = { 11,12,13,14,15};

            ViewData["Numbers"] = numbers;

            // TempData can be used to send the value across the action methods, but the limitation is: it can be used only once after its initialization
            TempData["Dev_Name"] = "Mugdha";

            return View();
        }

        public IActionResult About() 
        {
           
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
