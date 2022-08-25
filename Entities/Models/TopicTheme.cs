namespace Entities.Models
{
    public class TopicTheme
    {
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
        public bool IsMainTheme { get; set; }
    }
}