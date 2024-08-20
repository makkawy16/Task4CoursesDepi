namespace Task4Courses.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Degree { get; set; }
        public double MinimumDegree { get; set; }

        public virtual ICollection<Instractor> Instractors { get; set; }
        public virtual ICollection<CourseResult> CourseResults { get; set; }

    }
}
