using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class TrainingPlan
{
    public int Id { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public int InstructorId { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Instructor Instructor { get; set; } = null!;
}
