using Microsoft.EntityFrameworkCore;

namespace _10Demo_CRUD_EF_WebAPI.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> Emps { get; set; }
        public EmpDbContext(DbContextOptions options):base(options) 
        {
            
        }
    }
}
