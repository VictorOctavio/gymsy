using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class ClientAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdClient { get; set; }

    public int IdPerson { get; set; }

    public int IdTrainingPlan { get; set; }

    public DateTime? LastExpirationAntigua { get; set; }

    public DateTime? LastExpirationNueva { get; set; }

    public virtual Client? IdClientNavigation { get; set; }
}
