using System;

namespace _05.IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ConverToBase(num, b));
            
        }

        static string ConverToBase(int num, int b)
        {
            string result = string.Empty;
            while(num != 0)
            {
                result = (num % b) + result;
                num = num / b;
            }
            return result;
        }
    }
}
