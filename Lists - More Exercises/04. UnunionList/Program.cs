using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for(int j = 0; j < list.Count; j++)
                {
                    if (nums.Contains(list[j]))
                    {
                        nums.RemoveAll(x => x == list[j]);
                    }
                    else
                    {
                        nums.Add(list[j]);
                    }
                }
            }

            nums.Sort();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
