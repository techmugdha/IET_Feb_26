using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _11Demo_DBFirst.Models;

[Table("products")]
[Index("ProductCategoryCategoryId", Name = "IX_products_ProductCategoryCategoryId")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public string ProductImage { get; set; } = null!;

    public double Price { get; set; }

    [Column("isInStock")]
    public bool IsInStock { get; set; }

    public int ProductCategoryCategoryId { get; set; }

    [ForeignKey("ProductCategoryCategoryId")]
    [InverseProperty("Products")]
    public virtual Category ProductCategoryCategory { get; set; } = null!;
}
