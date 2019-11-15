using System.Data.Entity;
using WorkWithModel.Models;

namespace WorkWithModel.DataAccess
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
            : base("name=ArticleContext")
        {
            Database.SetInitializer(new ArticleInitializer());
        }

        public DbSet<Article> News { get; set; }
    }
}