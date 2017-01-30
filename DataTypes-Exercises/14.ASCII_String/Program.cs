using System;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "" ;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                char b = (char)a;
                word = word + b;
            }
            Console.WriteLine(word);
        }
    }
}
