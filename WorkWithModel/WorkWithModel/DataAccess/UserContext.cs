using System.Data.Entity;
using WorkWithModel.Models;

namespace WorkWithModel.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
            Database.SetInitializer(new UserInitializer());
        }

        public DbSet<User> Users { get; set; }
    }

}