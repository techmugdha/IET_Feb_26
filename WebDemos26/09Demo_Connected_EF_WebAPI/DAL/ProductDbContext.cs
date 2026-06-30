using _09Demo_Connected_EF_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _09Demo_Connected_EF_WebAPI.DAL
{
    public class ProductDbContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public ProductDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
