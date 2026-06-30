using System.Diagnostics;
using _09Demo_Connected_EF_WebAPI.DAL;
using _09Demo_Connected_EF_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace _09Demo_Connected_EF_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _dbContext;

        public HomeController(EmpDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            //var result1 = _dbContext.Emps;
            var result = _dbContext.GetAllEmpRecords();
            return View(result);
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
