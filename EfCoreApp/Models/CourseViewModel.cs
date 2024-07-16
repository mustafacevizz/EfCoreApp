using EfCoreApp.Data;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Models
{
    public class CourseViewModel
    {
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Course Title")]
        public string? Title { get; set; }
        public int TeacherId { get; set; }
        
        public ICollection<RegisterCourse> RegisterCourses { get; set; } = new List<RegisterCourse>();
    }
}

