using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var first = new List<int>();
            var second = new List<int>();
            var digitList = new List<int>();

            for(int i = 0; i < num.Count / 2; i ++)
            {
                first.Add(num[i]);
            }

            for(int i = num.Count / 2; i < num.Count; i ++)
            {
                second.Add(num[i]);
            }

            for (int i = 0; i < first.Count; i++)
            {
                digitList.Add(second[i] / 10);
                digitList.Add(first[i]);
                digitList.Add(second[i] % 10);
            }
            Console.WriteLine(string.Join(" ", digitList));

        }
    }
}
