using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class Capacity
    {
        [Key]
        public int CapacityId { get; set; }
        [Required]
        [MaxLength(200)]
        public string CapacityName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }
    }
}
