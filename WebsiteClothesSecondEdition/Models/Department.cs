using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebsiteClothesSecondEdition.Models;

public partial class Department
{
    public int Id { get; set; }
    [Required(ErrorMessage = "This field can't be empty")]
    [Display(Name = "Name")]
    public string DepartmentName { get; set; } = null!;
    [Required(ErrorMessage = "This field can't be empty")]
    [Display(Name = "ID of the department")]
    public int DepartmentNameId { get; set; }
    [Required(ErrorMessage = "This field can't be empty")]
    [Display(Name = "Amount of sales per year")]
    public int DepartmentSales { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
