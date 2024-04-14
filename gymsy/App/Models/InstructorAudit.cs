using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class InstructorAudit
{
    public int IdInstructor { get; set; }

    public int IdPerson { get; set; }

    public virtual Instructor IdInstructorNavigation { get; set; } = null!;

    public virtual Person IdPersonNavigation { get; set; } = null!;
}
