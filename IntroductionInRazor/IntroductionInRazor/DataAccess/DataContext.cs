using IntroductionInRazor.Models;
using System.Data.Entity;

namespace IntroductionInRazor.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}