using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(200)]
        public string CourseName { get; set; }
        public ICollection<EventContent> EventContents { get; set; }
    }
}
