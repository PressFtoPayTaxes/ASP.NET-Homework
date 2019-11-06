namespace MethodsSelectorsAndAttributes.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class NewsContext : DbContext
    {
        public NewsContext() : base("name=NewsContext")
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}