using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class User : Entity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual LikedPostsList LikedPosts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
