using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Administrator
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;
}
