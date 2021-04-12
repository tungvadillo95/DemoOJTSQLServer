using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class EventContentCapacity
    {
        [Required]
        public int EventContentId { get; set; }
        public EventContent EventContent { get; set; }
        [Required]
        public int CapacityId { get; set; }
        public Capacity Capacity { get; set; }


    }
}
