using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public double Amount { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;
}
