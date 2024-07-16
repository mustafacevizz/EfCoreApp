using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public string? TeacherSurname { get; set; }
        public string TeacherFullName
        {
            get

            {
                return this.TeacherName + " " + this.TeacherSurname;
            }
        }
        public string? TeacherMail { get; set; }
        public string? TeacherPhone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =false)]
        public DateTime StartingDate { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
