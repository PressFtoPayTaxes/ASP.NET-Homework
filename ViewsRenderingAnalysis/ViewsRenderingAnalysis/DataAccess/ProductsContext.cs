using System.Data.Entity;
using ViewsRenderingAnalysis.Models;

namespace ViewsRenderingAnalysis.DataAccess
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContext")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}