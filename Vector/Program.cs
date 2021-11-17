using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random r = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next();
            }
            Vector vect = new Vector(array);
            vect.Print(1);
            vect.Print();
            vect[2] = 5;
            Console.WriteLine(vect[2]);
            vect.Multiplie(2);
            vect.Print(2);
            Console.WriteLine("Hello World!");
        }
    }
}
