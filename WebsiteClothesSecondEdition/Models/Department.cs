using System;
using System.Collections.Generic;

namespace WebsiteClothesSecondEdition.Models;

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int DepartmentNameId { get; set; }

    public int DepartmentSales { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
