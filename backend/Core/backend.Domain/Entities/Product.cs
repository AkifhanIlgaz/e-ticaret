using System;
using backend.Domain.Entities.Common;

namespace backend.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
}
