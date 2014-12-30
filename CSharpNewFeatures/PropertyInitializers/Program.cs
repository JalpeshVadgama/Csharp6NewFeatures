using System;

namespace PropertyInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine(nameof(student));
            Console.WriteLine("Id= {0}", student.StudentId);
            Console.WriteLine("FirstName= {0}", student.FirstName);
            Console.WriteLine("LastName= {0}", student.LastName);

            Student anotherStudent = new Student
            {
                FirstName="Vishal",
                LastName="Vadgama"
            };

            Console.WriteLine(nameof(anotherStudent));
            Console.WriteLine("Id= {0}", anotherStudent.StudentId);
            Console.WriteLine("FirstName= {0}", anotherStudent.FirstName);
            Console.WriteLine("LastName= {0}", anotherStudent.LastName);
        }
    }

    
}
