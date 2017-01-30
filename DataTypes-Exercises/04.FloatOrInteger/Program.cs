using System;

namespace _04.FloatOrInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a % 1 == 0) Console.WriteLine(a);
            else Console.WriteLine(Math.Round(a));
        }
    }
}
