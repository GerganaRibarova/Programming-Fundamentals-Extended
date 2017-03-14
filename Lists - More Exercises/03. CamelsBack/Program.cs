using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBack = int.Parse(Console.ReadLine());
            int rounds = 0;

            if (camelsBack == buildings.Count)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));

            }
            else
            {
                while (camelsBack != buildings.Count)
                {
                    buildings.RemoveAt(buildings.Count - 1);
                    buildings.RemoveAt(0);
                    rounds++;
                }

                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
        }
    }
}
