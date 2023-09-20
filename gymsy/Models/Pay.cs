using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Pay
{
    public DateTime CreatedAt { get; set; }

    public int Id { get; set; }

    public DateTime Expiration { get; set; }

    public int DestinatarioId { get; set; }

    public int RemitenteId { get; set; }

    public int PaytypeId { get; set; }

    public virtual Person Destinatario { get; set; } = null!;

    public virtual PayType Paytype { get; set; } = null!;

    public virtual Person Remitente { get; set; } = null!;
}
