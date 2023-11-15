using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AlpineScheduler.Shared.Models
{
    public class Job
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public string Team { get; set; }

        public int StartTime { get; set; }

        public int Duration { get; set; }
    
    }
}
