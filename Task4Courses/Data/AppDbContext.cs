using Microsoft.EntityFrameworkCore;
using Task4Courses.Models;

namespace Task4Courses.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public AppDbContext() { }

        public DbSet<CourseResult> CourseResults { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instractor> Instractors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
