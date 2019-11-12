using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkWithModel.Models
{
    public class Article : Entity
    {
        public string Theme { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}