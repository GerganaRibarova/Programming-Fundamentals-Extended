using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).Distinct().ToList();
            Console.WriteLine(string.Join(" ", nums));


            for (int i = 0; i < nums.Count - 1; i++)
            {
                for(int j = i + 1; j < nums.Count ; j++)
                {
                    if (nums[i] == nums[j]) nums.RemoveAt(j);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
