using System;

namespace Configurations
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Basket Basket { get; set; } = new Basket();
        public string PhoneNumber { get; set; }
    }
}