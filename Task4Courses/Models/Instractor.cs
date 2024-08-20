using System.ComponentModel.DataAnnotations.Schema;

namespace Task4Courses.Models
{
    public class Instractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
