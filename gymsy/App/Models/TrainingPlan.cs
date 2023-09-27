using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class TrainingPlan
{
    public int IdTrainingPlan { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public bool Inactive { get; set; }

    public int IdInstructor { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Instructor IdInstructorNavigation { get; set; } = null!;
}
