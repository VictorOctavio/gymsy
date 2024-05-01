using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class PayTypeAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdPayType { get; set; }

    public string Name { get; set; } = null!;

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public virtual PayType? IdPayTypeNavigation { get; set; }
}
