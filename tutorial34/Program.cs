using System;

namespace tutorial34
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Orange", "Yellow", "Green", "Light Blue", "Blue", "Violet" };
            string[] ranges = {"Radio", "IR", "Red", "Green", "UV", "X-Ray", "Gamma" };
            StringSet IS = new StringSet(colors);
            StringSet RN = new StringSet(ranges);
            IS.Remove("Light Blue");
            IS.Add("Black");
            for(int i=0; i<IS.Length; ++i)
                Console.WriteLine($"{IS[i]}");
            
            StringSet IntersS = IS.Intersection(RN);
            for (int i = 0; i < IntersS.Length; ++i)
                Console.WriteLine($"Intersections: {IntersS[i]}");

            StringSet DiffS = IS.Diff(RN);
            for (int i = 0; i < DiffS.Length; ++i)
                Console.WriteLine($"Diff: {DiffS[i]}");

            StringSet SumS = IS.Sum(RN);
            for (int i = 0; i < SumS.Length; ++i)
                Console.WriteLine($"Sum: {SumS[i]}");


        }
    }
}
