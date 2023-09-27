using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Instructor
{
    public int IdInstructor { get; set; }

    public int IdPerson { get; set; }

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual ICollection<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
}
