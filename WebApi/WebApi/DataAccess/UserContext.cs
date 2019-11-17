namespace WebApi.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApi.Models;

    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts{ get; set; }
    }
}