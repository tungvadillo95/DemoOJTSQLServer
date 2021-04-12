using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class EventContent
    {
        [Key]
        public int EventContentId { get; set; }
        [Required]
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string StudentId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public int CourseCurrentId { get; set; }
        public Course Course { get; set; }
        [Required]
        public int StatusId { get; set; }

        public ICollection<EventContentCapacity> EventContentCapacities { get; set; }
    }
}
