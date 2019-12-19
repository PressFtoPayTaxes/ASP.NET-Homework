using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class LikedPostsList : Entity
    {
        public virtual ICollection<LikedPostsListPost> LikedPostListPosts { get; set; }
        public virtual User User { get; set; }
        public Guid UserId { get; set; }
    }
}
