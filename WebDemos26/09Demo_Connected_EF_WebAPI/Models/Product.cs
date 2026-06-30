using System.ComponentModel.DataAnnotations;

namespace _09Demo_Connected_EF_WebAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public double Price { get; set; }
        public bool isInStock { get; set; }

        public Category ProductCategory { get; set; }
    }
}
