using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MethodsSelectorsAndAttributes.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public string ImageSource { get; set; }
    }
}