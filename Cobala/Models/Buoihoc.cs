using System;
using System.Collections.Generic;

namespace Cobala.Models;

public partial class Buoihoc
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Timed { get; set; } = null!;

    public string? Description { get; set; }
}
