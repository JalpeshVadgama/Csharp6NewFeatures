using System;

namespace NameOfOpeartor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
                                { FirstName = "Jalpesh",
                                LastName = "Vadgama" };
            Print(null);
        }
        static void Print(Employee employee)
        {
            //Old way of doing it
            //if (employee == null)
            //    throw new ArgumentException("employee");

            if (employee == null)
                throw new ArgumentException(nameof(employee));

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
