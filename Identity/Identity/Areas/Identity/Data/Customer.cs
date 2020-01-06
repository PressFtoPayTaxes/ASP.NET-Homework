using Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Areas.Identity.Data
{
    public class Customer
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
