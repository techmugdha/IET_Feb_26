using _10Demo_CRUD_EF_WebAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _10Demo_CRUD_EF_WebAPI.Controllers
{
    [EnableCors(PolicyName ="IET")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly EmpDbContext _dbcontext;

        //[HttpGet] // "api/Values"
        //public string[] GetData()
        //{
        //    return new string[] { "Hi", "Hello", "Bye"};
        //}
        public ValuesController(EmpDbContext context)
        {
            _dbcontext = context;
        }
        [HttpGet]
        public IEnumerable<Emp> GetEmps()
        {
            var emps = _dbcontext.Emps.ToList();
            return emps;
        }

        [HttpPost]
        public void Post(Emp emp)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Emps.Add(emp);
                _dbcontext.SaveChanges();
            }
        }

        [HttpPut("{id}")]// Put: api/Data/id
        public void Put(int id, Emp emp)
        {
            Emp e = _dbcontext.Emps.Find(id);
            e.Name = emp.Name;
            e.Address = emp.Address;
            _dbcontext.SaveChanges();
        }

        [HttpDelete("{id}")]// Put: api/Data/id
        public void Delete(int id)
        {
            Emp e = _dbcontext.Emps.Find(id);
            _dbcontext.Emps.Remove(e);
            _dbcontext.SaveChanges();
        }
    }
}
