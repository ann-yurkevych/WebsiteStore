using System;
using System.Collections.Generic;

namespace WebsiteClothesSecondEdition.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string YearProduction { get; set; } = null!;

    public string YearRelease { get; set; } = null!;

    public decimal Price { get; set; }

    public int DepartmentId { get; set; }

    public int CountryId { get; set; }

    public int MaterialId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
