namespace _09Demo_Connected_EF_WebAPI.Models
{
    public class ProductViewModel
    {
        public List<Product> allProducts { get; set; }
        public List<Category> allCategories { get; set; }
        public int currentProductCategoryId { get; set; }
        public ProductViewModel()
        {
            currentProductCategoryId = 1;
        }

    }
}
