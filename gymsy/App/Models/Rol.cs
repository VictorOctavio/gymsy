using System;
using System.Collections.Generic;

namespace gymsy.App.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string Name { get; set; } = null!;

    public bool Inactive { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
