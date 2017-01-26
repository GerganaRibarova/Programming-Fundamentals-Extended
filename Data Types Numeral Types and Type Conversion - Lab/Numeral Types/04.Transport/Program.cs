using System;

namespace _04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)n / 24);
            Console.WriteLine(courses);
        }
    }
}
