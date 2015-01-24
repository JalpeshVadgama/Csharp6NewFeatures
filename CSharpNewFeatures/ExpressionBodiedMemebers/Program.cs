using System;

namespace ExpressionBodiedMemebers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Jalpesh",
                LastName = "Vadgama"
            };
            Console.WriteLine(person.GetFullName());
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return string.Format("{FirstName} {LastName}");
        }
    }
}
