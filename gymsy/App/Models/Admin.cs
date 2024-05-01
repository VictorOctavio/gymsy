using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public double Recaudacion { get; set; }

    public int IdPerson { get; set; }

    public virtual ICollection<AdminAudit> AdminAudits { get; set; } = new List<AdminAudit>();

    public virtual Person IdPersonNavigation { get; set; } = null!;
}
