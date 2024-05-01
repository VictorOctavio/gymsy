using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class DataFisicAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdDataFisic { get; set; }

    public int IdClient { get; set; }

    public string? TitleAntigua { get; set; }

    public string? TitleNueva { get; set; }

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public string? NotesAntigua { get; set; }

    public string? NotesNueva { get; set; }

    public DateTime? CreatedAtAntigua { get; set; }

    public DateTime? CreatedAtNueva { get; set; }

    public double? HeightAntigua { get; set; }

    public double? HeightNueva { get; set; }

    public double? WeightAntigua { get; set; }

    public double? WeightNueva { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual DataFisic? IdDataFisicNavigation { get; set; }
}
