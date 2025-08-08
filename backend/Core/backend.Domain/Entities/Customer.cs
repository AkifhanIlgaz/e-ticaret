using System;
using backend.Domain.Entities.Common;

namespace backend.Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}
