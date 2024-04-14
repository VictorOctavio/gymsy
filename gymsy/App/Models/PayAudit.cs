using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class PayAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdPay { get; set; }

    public int DestinatarioId { get; set; }

    public int RemitenteId { get; set; }

    public int IdPayType { get; set; }

    public double? AmountAntigua { get; set; }

    public double? AmountNueva { get; set; }

    public DateTime? CreatedAtAntigua { get; set; }

    public DateTime? CreatedAtNueva { get; set; }

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public virtual Person Destinatario { get; set; } = null!;

    public virtual Pay? IdPayNavigation { get; set; }

    public virtual PayType IdPayTypeNavigation { get; set; } = null!;

    public virtual Person Remitente { get; set; } = null!;
}
