using System;
using System.Collections.Generic;

namespace WebsiteClothesSecondEdition.Models;

public partial class CustomerOrder
{
    public int Id { get; set; }

    public string CustomerId { get; set; } = null!;

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;
}
