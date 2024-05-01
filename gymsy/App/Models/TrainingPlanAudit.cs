using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class TrainingPlanAudit
{
    public int AuditId { get; set; }

    public DateTime ActionDate { get; set; }

    public string ActionUser { get; set; } = null!;

    public string ActionType { get; set; } = null!;

    public int? IdTrainingPlan { get; set; }

    public int IdInstructor { get; set; }

    public double? PriceAntigua { get; set; }

    public double? PriceNueva { get; set; }

    public string? DescriptionAntigua { get; set; }

    public string? DescriptionNueva { get; set; }

    public bool? InactiveAntigua { get; set; }

    public bool? InactiveNueva { get; set; }

    public virtual Instructor IdInstructorNavigation { get; set; } = null!;

    public virtual TrainingPlan? IdTrainingPlanNavigation { get; set; }
}
