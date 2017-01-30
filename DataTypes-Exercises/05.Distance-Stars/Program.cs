using System;

namespace _05.Distance_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal nearestYear = 4.22m * lightYear;
            decimal galaxyCenter = 26000 * lightYear;
            decimal diameter = 100000 * lightYear;
            decimal universe = 46500000000 * lightYear;
            Console.WriteLine("{0:e2}",nearestYear);
            Console.WriteLine("{0:e2}", galaxyCenter);
            Console.WriteLine("{0:e2}", diameter);
            Console.WriteLine("{0:e2}", universe);
        }
    }
}
