namespace Task4Courses.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public double Degree { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
