 namespace DSS.Models
{
    public enum Gender { Male, Female }
    public class Person 
    {
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public Gender Gender { get; set; } = Gender.Male;
        public PostalAddress Address = new PostalAddress(){
                                                Street = "",
                                                City = "",
                                                PostalCode = "",
                                                State = ""
                                            };
    }
}