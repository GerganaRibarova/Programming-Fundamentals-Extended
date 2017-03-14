using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = nums.Count / 2;
            int br = 2;

            for(int i = 1; i < n; i++)
            {
                int a = nums[i];
                nums[i] = nums[nums.Count - br];
                nums[nums.Count - br] = a;
                br++;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
