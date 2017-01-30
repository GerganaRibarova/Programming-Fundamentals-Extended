using System;

namespace _16.TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                if (i < n - 1)
                {
                    text += word;
                    text += delimiter;
                }
                else if (i == n - 1)
                {
                    text += word;
                }
            }

            Console.WriteLine(text);
        }
    }
}
