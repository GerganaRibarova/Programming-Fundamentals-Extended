using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for(int i = 0; i < first.Count; i++)
            {
                
                  second.RemoveAll(num => num == first[i]);
            }

            int sumFirst = 0;
            int sumSecond = 0;

            for(int i = 0; i < first.Count; i++)
            {
                sumFirst += first[i];
            }

            for(int i = 0; i < second.Count; i++)
            {
                sumSecond += second[i];
            }

            if (sumFirst == sumSecond) Console.WriteLine($"Yes. Sum: {sumFirst}");
            else Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirst - sumSecond));
        }
    }
}
