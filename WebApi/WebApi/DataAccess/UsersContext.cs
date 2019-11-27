namespace WebApi.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApi.Models;

    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("name=UsersContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts{ get; set; }
    }
}