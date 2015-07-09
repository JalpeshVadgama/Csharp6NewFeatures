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
            Console.ReadKey();
        }
        static void Print(Employee employee)
        {
            try
            {
                //Old way of doing it
                //if (employee == null)
                //    throw new ArgumentException("employee");

                if (employee == null)
                    throw new ArgumentException(nameof(employee));

                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
