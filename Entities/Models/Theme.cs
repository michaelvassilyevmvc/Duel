using System.Collections.Generic;

namespace Entities.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TopicTheme> Topics { get; set; }
    }
}