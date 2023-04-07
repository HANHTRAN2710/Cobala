using System;
using System.Collections.Generic;

namespace Cobala.Models;

public partial class Chuongtrinhhoc
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
