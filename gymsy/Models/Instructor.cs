using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public virtual ICollection<PayPlan> PayPlans { get; set; } = new List<PayPlan>();

    public virtual Person Person { get; set; } = null!;
}
