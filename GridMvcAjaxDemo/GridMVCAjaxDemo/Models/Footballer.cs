namespace GridMVCAjaxDemo.Models
{
    public class Footballer
    {
        public Footballer(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}