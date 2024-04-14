using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Pay
{
    public int IdPay { get; set; }

    public DateTime CreatedAt { get; set; }

    public double Amount { get; set; }

    public bool Inactive { get; set; }

    public int DestinatarioId { get; set; }

    public int RemitenteId { get; set; }

    public int IdPayType { get; set; }

    public virtual Person Destinatario { get; set; } = null!;

    public virtual PayType IdPayTypeNavigation { get; set; } = null!;

    public virtual ICollection<PayAudit> PayAudits { get; set; } = new List<PayAudit>();

    public virtual Person Remitente { get; set; } = null!;
}
