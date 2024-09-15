using System;
using System.Collections.Generic;

namespace PeruAPI.Data;

public partial class Product
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public decimal? UnirPrice { get; set; }
}
