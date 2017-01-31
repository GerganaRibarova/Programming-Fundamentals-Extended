using System;

namespace _03.StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str, count));
        }

        static string RepeatString(string str, int count)
        {
            string repeated = string.Empty;
            for(int i = 0; i < count; i++)
            {
                repeated += str;
            }
            return repeated;
        }
    }
}
