﻿using System;
using System.Collections.Generic;

namespace BE.Models;

public partial class ProductSize
{
    public int ProductSizeId { get; set; }

    public int ProductId { get; set; }

    public int SizeId { get; set; }

    public int? Quanity { get; set; }

    public int? Price { get; set; }

    public int? IsDelete { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Product Product { get; set; } = null!;

    public virtual Size Size { get; set; } = null!;
}
