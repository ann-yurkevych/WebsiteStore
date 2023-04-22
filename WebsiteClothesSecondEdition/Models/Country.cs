using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebsiteClothesSecondEdition.Models;

public partial class Country
{
    public int Id { get; set; }
    [Required(ErrorMessage = "This field can't be empty")]
    [Display(Name = "Country of the producer")]
    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
