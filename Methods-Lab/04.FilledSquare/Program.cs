using System;

namespace _04.FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Border(n);
            for(int i = 0; i < n-2; i ++)
            {
                Middle(n);
            }
            
            Border(n);
        }

        static void Border(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void Middle(int n)
        {
            Console.Write('-');
            for(int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }
    }
}
