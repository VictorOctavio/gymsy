using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Person
{
    public string Nickname { get; set; } = null!;

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Avatar { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public int Cbu { get; set; }

    public int RolId { get; set; }

    public virtual ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<Pay> PayDestinatarios { get; set; } = new List<Pay>();

    public virtual ICollection<Pay> PayRemitentes { get; set; } = new List<Pay>();

    public virtual Rol Rol { get; set; } = null!;

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
