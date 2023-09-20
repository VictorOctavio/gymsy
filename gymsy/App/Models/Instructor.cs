using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual ICollection<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
}
