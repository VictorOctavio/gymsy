using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class ImageAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdImage { get; set; }

    public int IdDataFisic { get; set; }

    public string? ImageUrlAntigua { get; set; }

    public string? ImageUrlNueva { get; set; }

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public string? NotesAntigua { get; set; }

    public string? NotesNueva { get; set; }

    public virtual DataFisic IdDataFisicNavigation { get; set; } = null!;

    public virtual Image? IdImageNavigation { get; set; }
}
