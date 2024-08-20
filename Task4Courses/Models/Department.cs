namespace Task4Courses.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public virtual ICollection<Instractor> Instractors { get; set; }

    }
}
