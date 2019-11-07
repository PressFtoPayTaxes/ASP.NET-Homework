using System;

namespace IntroductionInRazor.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Author { get; set; }
        public string Text { get; set; }
    }
}