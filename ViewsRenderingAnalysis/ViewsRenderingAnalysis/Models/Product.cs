using System;

namespace ViewsRenderingAnalysis.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}