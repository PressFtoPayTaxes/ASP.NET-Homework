using AspNetMVCCoreVsMVCFrameworkComparison2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcCoreVsMvcFrameworkComparison2.Models
{
    public class Admin
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public Guid PortfolioId { get; set; }
    }
}
