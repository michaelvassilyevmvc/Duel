using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class TopicDisputer
    {
        [Key, Column(Order = 1)]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        [Key, Column(Order = 2)]
        public int DisputerId { get; set; }
        public Disputer Disputer { get; set; }

        public bool IsWinner { get; set; }


    }
}
