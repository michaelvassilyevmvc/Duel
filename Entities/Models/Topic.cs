using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public virtual ICollection<TopicDisputer> Disputers { get; set; } = new List<TopicDisputer>();
        public virtual ICollection<TopicTheme> Themes { get; set; }


    }
}