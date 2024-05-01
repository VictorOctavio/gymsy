using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class RolAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdRol { get; set; }

    public string NameAntigua { get; set; } = null!;

    public string NameNueva { get; set; } = null!;

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
