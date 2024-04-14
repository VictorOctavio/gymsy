using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class AdminAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdAdmin { get; set; }

    public int IdPerson { get; set; }

    public double? RecaudacionAntigua { get; set; }

    public double? RecaudacionNueva { get; set; }

    public virtual Admin? IdAdminNavigation { get; set; }
}
