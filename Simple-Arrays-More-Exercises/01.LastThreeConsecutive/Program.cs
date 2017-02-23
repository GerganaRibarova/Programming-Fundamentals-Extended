using System;

namespace _01.LastThreeConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int n = words.Length;

            string consecutive = words[n-1];
            for(int i = n; i > 0; i--)
            {
                if (words[i - 1] == words[i - 2] && words[i - 1] == words[i - 3])
                {
                    consecutive = words[i - 1]; break;
                }
            }

            Console.WriteLine(consecutive);
        }
    }
}
