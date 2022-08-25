using System.Collections.Generic;

namespace Entities.Models
{
    public class Disputer
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<TopicDisputer> Topics { get; set; } = new List<TopicDisputer>();
    }
}