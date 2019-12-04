using System;
using System.Collections.Generic;

namespace Configurations
{
    public class Basket
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual User User { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public double Bill { get; set; }
    }
}
