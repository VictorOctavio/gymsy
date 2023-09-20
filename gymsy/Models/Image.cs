using System;
using System.Collections.Generic;

namespace gymsy.Models;

public partial class Image
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Notes { get; set; }

    public int DatafisicId { get; set; }

    public virtual DataFisic Datafisic { get; set; } = null!;
}
