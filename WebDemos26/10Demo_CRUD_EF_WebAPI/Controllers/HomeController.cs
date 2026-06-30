using System.Diagnostics;
using _10Demo_CRUD_EF_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10Demo_CRUD_EF_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _context;

        public HomeController(EmpDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Emps.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            // ModelBinder has created Model Emp object successfully or not?
            if (ModelState.IsValid)
            {
                _context.Emps.Add(emp);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var empToBeEdited = _context.Emps.Find(id);
            return View(empToBeEdited);
        }

        [HttpPost]
        public IActionResult Edit(int? id,Emp emp)
        {
            if (ModelState.IsValid) 
            {
                var empToBeEdited = _context.Emps.Find(id);
                empToBeEdited.Name = emp.Name;
                empToBeEdited.Address = emp.Address;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var emp = _context.Emps.Find(id);
                return View(emp);
            }
            return NotFound();
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var emp = _context.Emps.Find(id);
                _context.Emps.Remove(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
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
