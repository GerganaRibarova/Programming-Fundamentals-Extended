using System;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = GetMin(GetMin(a, b), GetMin(b, c));
            Console.WriteLine(min);
        }

        static int GetMin(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
    }
}
