using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Image
{
    public int IdImage { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Notes { get; set; }

    public bool Inactive { get; set; }

    public int IdDataFisic { get; set; }

    public virtual DataFisic IdDataFisicNavigation { get; set; } = null!;

    public virtual ICollection<ImageAudit> ImageAudits { get; set; } = new List<ImageAudit>();
}
