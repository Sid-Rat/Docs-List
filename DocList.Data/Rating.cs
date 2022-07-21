using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocList.Data
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(JobType))]
        public int JobTypeId { get; set; }
        public virtual JobType JobType { get; set; }
        public double Score { get; set; }

    }
}
