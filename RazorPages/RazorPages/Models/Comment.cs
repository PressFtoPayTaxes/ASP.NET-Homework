namespace RazorPages.Models
{
    public class Comment : Entity
    {
        public virtual User User { get; set; }
        public string Text { get; set; }
        public virtual Post Post { get; set; }
    }
}