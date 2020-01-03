using Microsoft.EntityFrameworkCore;
using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<LikedPostsListPost> LikedPostsListPosts { get; set; }
        public DbSet<LikedPostsList> LikedPostsLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LikedPostsListPost>().HasKey(sc => new { sc.LikedPostsListId, sc.PostId });
        }
    }
}
