using System;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Id = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama"
            };
            PrintAddress(person);

        }
        static void PrintAddress(Person person)
        {
            //Old way of doing this.
            Address address = person?.Address;
            if (address != null)
            {
                Console.WriteLine(address.Street);
                Console.WriteLine(address.City);
            }
        } 
    }
}
