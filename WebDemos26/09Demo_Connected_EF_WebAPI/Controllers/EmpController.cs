using _09Demo_Connected_EF_WebAPI.DAL;
using Microsoft.AspNetCore.Mvc;

namespace _09Demo_Connected_EF_WebAPI.Controllers
{
    public class EmpController : Controller
    {
        private readonly EmpDataDbContext _dbContext;

        public EmpController(EmpDataDbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            var allEmps = _dbContext.Emps.ToList();
            return View(allEmps);
        }
    }
}
