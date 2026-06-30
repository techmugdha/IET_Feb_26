using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _11Demo_DBFirst.Models;

[Table("categories")]
public partial class Category
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    [InverseProperty("ProductCategoryCategory")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
