using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TriangleFormations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            if(a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("Triangle is valid.");

               double a1 = Math.Pow(a, 2);
               double b1 = Math.Pow(b, 2);
               double c1 = Math.Pow(c, 2);

                if (a1 + b1 == c1) Console.WriteLine("Triangle has a right angle between sides a and b");
                else if (b1 + c1 == a1) Console.WriteLine("Triangle has a right angle between sides b and c");
                else if (a1 + c1 == b1) Console.WriteLine("Triangle has a right angle between sides a and c");
                else Console.WriteLine("Triangle has no right angles");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
