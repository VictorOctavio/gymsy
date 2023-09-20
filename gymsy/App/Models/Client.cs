using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Client
{
    public int Id { get; set; }

    public DateTime LastExpiration { get; set; }

    public int PersonId { get; set; }

    public int PlanId { get; set; }

    public virtual ICollection<DataFisic> DataFisics { get; set; } = new List<DataFisic>();

    public virtual Person Person { get; set; } = null!;

    public virtual TrainingPlan Plan { get; set; } = null!;
}
