using System;

namespace _03.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }

            for(int i= n - 1; i >= 1; i --)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int n)
        {
            for(int i = 1; i <= n; i ++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
        }
    }
}
