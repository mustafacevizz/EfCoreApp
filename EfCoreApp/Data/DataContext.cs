using Microsoft.EntityFrameworkCore;

namespace EfCoreApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
        }
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<RegisterCourse> AllRegisters => Set<RegisterCourse>();
    }

    //code-first => entity, dbcontext => database
    //database-first => sql server
}
