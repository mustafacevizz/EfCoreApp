namespace EfCoreApp.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public int TeacherId { get; set; } 
        public Teacher Teacher { get; set; } = null!;   //More than one teacher may teach a course
        public ICollection<RegisterCourse> RegisterCourses {  get; set; } = new List<RegisterCourse>();
    }
}
