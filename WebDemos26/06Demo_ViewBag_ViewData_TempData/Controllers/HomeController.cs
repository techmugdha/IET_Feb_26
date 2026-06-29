using System.Collections;
using System.Diagnostics;
using _06Demo_ViewBag_ViewData_TempData.IETDbViewModels;
using _06Demo_ViewBag_ViewData_TempData.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06Demo_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> emps = new List<Emp>()
            {
                new Emp(){ Id= 1, Name ="Ganesh", Address="Pune"},
                 new Emp(){ Id= 2, Name ="Prathmesh", Address="Panji"},
                new Emp(){ Id= 3, Name ="Mitesh", Address="Patna"},
                new Emp(){ Id= 4, Name ="Jignesh", Address="Surat"},
                new Emp(){ Id= 5, Name ="Suresh", Address="Mumbai"},
            };

        List<Customer> custs = new List<Customer>() { 
            new Customer(){ CId = 11, CName = "Peter"},
            new Customer(){ CId = 12, CName = "Jean"},
            new Customer(){ CId = 13, CName = "Olivia"}
        };

        // One action method = one view 
        public IActionResult Index()
        {
            //string fullname = "Hugh Jackman";
            //return View("Index", fullname);

            // @Model is Razor Syntax(partial C# + partial html)
            // Model property(available in index.cshtml page) resolves what Entity type you are passing from action method to View
            // via View() method
            int id = 1234;
            return View(id);

        }

        public IActionResult GetEmpData()
        {
           //@Model : IEnumerable<Emp>
            return View(emps);
        }
        public IActionResult GetData()
        {
            //@Model : ViewModel = IEnumerable<Emp>+IEnumerable<Customer>
            IETDbViewModel viewmodelObj = new IETDbViewModel() { allEmployees = emps, allCustomers= custs};

            return View( viewmodelObj);
        }
        public IActionResult GetData1()
        {
            //@Model : IEnumerable<Emp>
            //@Model : IEnumerable<Customer>
            //@Model : System.Collections.ArrayList
            ArrayList arrlst = new ArrayList() { emps, custs};
            return View("GetData1", arrlst);
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
