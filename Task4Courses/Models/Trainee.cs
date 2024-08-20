﻿namespace Task4Courses.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public double Grade { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }

    }
}
