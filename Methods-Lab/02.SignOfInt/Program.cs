using System;

namespace _02.SignOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign(int num)
        {
            if (num > 0) Console.WriteLine($"The number {num} is positive.");
            if (num < 0) Console.WriteLine($"The number {num} is negative.");
            if (num == 0) Console.WriteLine($"The number {num} is zero.");
        }
    }
}
