using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string StudentFullName
        {
            get

            {
                return this.StudentName + " " + this.StudentSurname;
            }
        }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }

        public ICollection<RegisterCourse> RegisterCourses { get; set; } = new List<RegisterCourse>();
    }
}
