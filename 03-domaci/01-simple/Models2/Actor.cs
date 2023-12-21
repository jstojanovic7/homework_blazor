namespace DSS.Models2
{
    public class Actor: Man, IVanity
    {
        public double ImdbMark = 5;

        public int NumberOfOscars = 0;

        public int NumberOfBaftas = 0;

        public string Bragging(){
            return "I, " + LastName + " " + FirstName + " am the best actor!!!";
        } 

    }
}