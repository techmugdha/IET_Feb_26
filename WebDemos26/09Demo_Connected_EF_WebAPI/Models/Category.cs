using System.ComponentModel.DataAnnotations;

namespace _09Demo_Connected_EF_WebAPI.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        public List<Product> Products { get; set; }
    }
}
