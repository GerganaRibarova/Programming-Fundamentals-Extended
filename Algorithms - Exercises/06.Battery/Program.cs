using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battery
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var perHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int hours = int.Parse(Console.ReadLine());

            for(int i = 0; i < capacity.Count; i++)
            {
                double last = capacity[i] - hours * perHour[i];
                double percantage = last * 100 / capacity[i];
                if (last >= 0) Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", i + 1, last, percantage);
                else
                {
                    int neededHour =(int) Math.Ceiling(capacity[i] / perHour[i]);
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", i + 1, neededHour);
                }
            }
        }
    }
}
