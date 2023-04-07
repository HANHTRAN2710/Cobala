﻿using System;
using System.Collections.Generic;

namespace Cobala.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }

    public virtual ICollection<Chuongtrinhhoc> Chuongtrinhhocs { get; } = new List<Chuongtrinhhoc>();
}
