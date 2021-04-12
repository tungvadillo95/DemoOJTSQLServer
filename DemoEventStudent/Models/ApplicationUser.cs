using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        public int GuardianId { get; set; }
        public int CourseCurrentId { get; set; }
        public ICollection<EventContent> EventContents { get; set; }
    }
}
