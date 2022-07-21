using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocList.Data
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int JobTypeId { get; set; }
        public double Score { get; set; }

    }
}
