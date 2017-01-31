using System;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = MathPower(a, power);
            Console.WriteLine(result);
        }

        static double MathPower(double a, double power)
        {
            return Math.Pow(a, power);
        }
    }
}
