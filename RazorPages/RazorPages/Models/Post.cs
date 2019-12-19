using System.Collections.Generic;

namespace RazorPages.Models
{
    public class Post : Entity
    {
        public virtual User User { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<LikedPostsListPost> LikedPostsListPosts { get; set; }
        public int Likes { get; set; }
    }
}