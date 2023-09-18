using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class PayType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pay> Pays { get; set; } = new List<Pay>();
}
