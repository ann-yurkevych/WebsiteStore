using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebsiteClothesSecondEdition.Models;

public partial class Product
{
    public int Id { get; set; }
    
    [Display(Name = "Name of the product")]
    public string ProductName { get; set; } = null!;
    [Display(Name = "Year of production")]
    public string YearProduction { get; set; } = null!;

    [Display(Name = "Year of release")]

    public string YearRelease { get; set; } = null!;

    [Display(Name = "Price of the product")]
    public decimal Price { get; set; }
 
    [Display(Name = "ID of the department")]
    public int DepartmentId { get; set; }
  
    [Display(Name = "Country producer")]
    public int CountryId { get; set; }
    [Display(Name = "ID of the material")]
    public int MaterialId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
