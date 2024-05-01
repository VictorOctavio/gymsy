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

    public string? Title { get; set; }

    public virtual ICollection<DataFisicAudit> DataFisicAudits { get; set; } = new List<DataFisicAudit>();

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual ICollection<ImageAudit> ImageAudits { get; set; } = new List<ImageAudit>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
