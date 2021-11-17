using System;
using System.Collections.Generic;

namespace Romanian
{
    class Converter
    {
        private Dictionary<char, int> digits;

        public Converter()
        {
            digits = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };
         }
        public int Convert(string r)
        {
            string roma = r.ToUpper();
            int retVal = 0;
            char[] rarr = roma.ToCharArray(0, roma.Length);
            try
            {
                for (int i = 0; i < rarr.Length; ++i)
                {
                    if (i == rarr.Length - 1)
                        retVal += digits[rarr[i]];
                    else if (digits[rarr[i + 1]] > digits[rarr[i]])
                        retVal -= digits[rarr[i]];
                    else
                        retVal += digits[rarr[i]];
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException exc)
            {
                Console.WriteLine("Неверный ввод");
            }
            return retVal;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter();
            Console.Write("Enter romanian number: ");
            Console.WriteLine( c.Convert( Console.ReadLine() ) );
            Console.ReadKey();

        }
    }
}
