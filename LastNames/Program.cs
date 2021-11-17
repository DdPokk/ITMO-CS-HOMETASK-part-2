using System;
using System.Collections.Generic;

namespace LastNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inital = new List<string>() { "Ivanov", "Petrov", "Sidorov" };
            LastNames ln = new LastNames(inital);
            Console.Write("Enter search query: ");
            Console.WriteLine( ln.ProcessLastName( Console.ReadLine() ));
        }
    }
}
