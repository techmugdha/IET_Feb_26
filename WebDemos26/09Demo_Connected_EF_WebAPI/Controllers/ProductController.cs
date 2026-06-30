using _09Demo_Connected_EF_WebAPI.DAL;
using _09Demo_Connected_EF_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _09Demo_Connected_EF_WebAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _dbContext;

        public ProductController(ProductDbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Dashboard1()
        {
            //var products = _dbContext.products.Include(p=>p.ProductCategory).ToList();
            var products = _dbContext.products.ToList();
            return View(products);
        }

        public IActionResult ProductDetails(int? id)
        {
            Product prod = _dbContext.products.Find(id);
            return View(prod);
        }

        public IActionResult Dashboard(int? id)
        {
            ProductViewModel vm = new ProductViewModel();
            vm.allCategories = _dbContext.categories.ToList();
            if (id != null)
            {
                vm.allProducts = _dbContext.products.Where(p => p.ProductCategory.CategoryId == id).ToList();
            }
            else
            {
                vm.allProducts = _dbContext.products.Where(p => p.ProductCategory.CategoryId == vm.currentProductCategoryId).ToList();
            }
            return View(vm);
        }
    }
}
