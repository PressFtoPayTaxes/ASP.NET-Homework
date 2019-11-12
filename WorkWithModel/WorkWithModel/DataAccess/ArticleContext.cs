using System.Data.Entity;
using WorkWithModel.Models;

namespace WorkWithModel.DataAccess
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
            : base("name=ArticleContext")
        {
        }

        public DbSet<Article> News { get; set; }
    }
}