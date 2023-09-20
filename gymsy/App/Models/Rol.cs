using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Rol
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
