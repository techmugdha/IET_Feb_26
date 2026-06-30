using _09Demo_Connected_EF_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _09Demo_Connected_EF_WebAPI.DAL
{
    public class EmpDataDbContext:DbContext
    {
        public DbSet<Emp> Emps { get; set; }
        public EmpDataDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
