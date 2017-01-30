using System;

namespace _06.IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            var b = 256;

            if (number < b)
            {
                Console.WriteLine(number);
            }
            else if (number >= b)
            {
                Console.WriteLine(number % b);
                Console.WriteLine("Overflowed {0} times", (number / b));
            }
        }
    }
}
