namespace DSS.Models
{
    public class MasterStudent : Student
    {
        public string ThesisTopic { get; set; } = "";
        public string Advisor { get; set; } = "";
        public List<Grade> ElectiveGrades { get; set; } = new List<Grade>();
    }
}