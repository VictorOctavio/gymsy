using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public double Total { get; set; }

    public double Retirable { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;
}
