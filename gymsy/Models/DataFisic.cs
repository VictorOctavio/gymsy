using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class DataFisic
{
    public int Id { get; set; }

    public int Weight { get; set; }

    public int Height { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Notes { get; set; }

    public int ClientId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
