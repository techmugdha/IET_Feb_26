using _07Demo_LayoutPages_BootStrap_PartialViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07Demo_LayoutPages_BootStrap_PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
        public IActionResult EmpData()
        {
            List<Emp> emps= new List<Emp>() { 
                new Emp(){ Id  = 1, Name="Peter Bishop",Address="Another Universe"},
                 new Emp(){ Id  = 2, Name="Walter Bishop",Address="This Universe"},
                  new Emp(){ Id  = 3, Name="Olivia Dhunum",Address="This Universe"}
            };
            return View(emps);
        }
    }
}
