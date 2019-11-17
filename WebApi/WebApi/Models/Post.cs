using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ImageSource { get; set; }
        public string Description{ get; set; }
        public virtual User User { get; set; }
    }
}