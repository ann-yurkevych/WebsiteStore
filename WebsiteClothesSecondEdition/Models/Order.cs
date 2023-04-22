using System;
using System.Collections.Generic;

namespace WebsiteClothesSecondEdition.Models;

public partial class Order
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual Product Product { get; set; } = null!;
}
