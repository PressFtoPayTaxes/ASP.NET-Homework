using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.DTOs
{
    public class PostDTO
    {
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public Guid User { get; set; }
        public string AuthorName { get; set; }
    }
}