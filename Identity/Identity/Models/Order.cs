using Identity.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string InquiryName { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
