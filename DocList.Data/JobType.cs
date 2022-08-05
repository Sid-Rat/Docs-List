using System.ComponentModel.DataAnnotations;

namespace DocList.Data
{
    public class JobType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
    }
}
