namespace DSS.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Studies { get; set; } = "";
        public int YearLevel { get; set; }

         public List<Grade> ElectiveGrades { get; set; } = new List<Grade>();
    }
}