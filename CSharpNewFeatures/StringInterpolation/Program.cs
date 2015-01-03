using System;
namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jalpesh Vadgama";

            //Old way of string concentaionation 
            Console.WriteLine("My name is" + name);
            Console.WriteLine("My name is {0}", name);

            //New way of doing this
            Console.WriteLine("My name is \{name}");
        }
    }
}
