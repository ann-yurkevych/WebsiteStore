﻿using System;
using System.Collections.Generic;

namespace WebsiteClothesSecondEdition.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}