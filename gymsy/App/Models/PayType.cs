using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class PayType
{
    public int IdPayType { get; set; }

    public string Name { get; set; } = null!;

    public bool Inactive { get; set; }

    public virtual ICollection<PayAudit> PayAudits { get; set; } = new List<PayAudit>();

    public virtual ICollection<PayTypeAudit> PayTypeAudits { get; set; } = new List<PayTypeAudit>();

    public virtual ICollection<Pay> Pays { get; set; } = new List<Pay>();
}
