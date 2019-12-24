using AspNetMVCCoreVsMVCFrameworkComparison2.Models;
using System;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.Models
{
    public class WorkExample
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public virtual Portfolio Portfolio { get; set; }
        public string ImagePath { get; set; }
    }
}
