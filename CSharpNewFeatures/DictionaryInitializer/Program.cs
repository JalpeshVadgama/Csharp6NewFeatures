using System;
using System.Collections.Generic;

namespace DictionaryInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Person = new Dictionary<int, string>()
            {
                {1, "Jalpesh Vadgama" },
                {2, "Vishal Vadgama" }
            };
            foreach (var person in Person)
            {
                Console.WriteLine("Key : {0},Value: {1}",person.Key, person.Value);
            }
            Console.ReadKey();
        }
    }
}
