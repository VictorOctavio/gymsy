using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class PayPlan
{
    public int Id { get; set; }

    public int Price { get; set; }

    public int? Description { get; set; }

    public int InstructorId { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Instructor Instructor { get; set; } = null!;
}
