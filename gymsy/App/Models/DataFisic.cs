using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class DataFisic
{
    public int IdDataFisic { get; set; }

    public double Weight { get; set; }

    public double Height { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Notes { get; set; }

    public bool Inactive { get; set; }

    public int IdClient { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
