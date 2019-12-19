using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class LikedPostsListPost
    {
        public Guid LikedPostsListId { get; set; }
        public virtual LikedPostsList LikedPostsList{ get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
