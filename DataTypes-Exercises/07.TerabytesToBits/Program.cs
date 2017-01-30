using System;

namespace _07.TerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            a = a * 1024 * 1024 * 1024 * 1024 * 8;
            Console.WriteLine("{0:0}",a);
        }
    }
}
