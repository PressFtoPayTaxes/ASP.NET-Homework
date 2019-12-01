using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryConveyor.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid AuthorizationToken { get; set; } = Guid.NewGuid();
    }
}
