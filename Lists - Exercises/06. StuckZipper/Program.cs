using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for(int i = 0; i < first.Count; i++)
            {
                if (first[i] > 10)
                {
                    first.Remove(first[i]);
                    i--;
                }
                
            }

            for (int i = 0; i < second.Count; i++)
            {
                if (second[i] > 10)
                {
                    second.Remove(second[i]);
                    i--;
                }

            }

            var zipper = new List<int>();
            var maxLength = Math.Max(first.Count, second.Count);
            var minLength = Math.Min(first.Count, second.Count);
            for (int i = 0; i < minLength; i++)
            {
                zipper.Add(second[i]);
                zipper.Add(first[i]);
            }

            if(first.Count > second.Count)
            {
                for(int i = minLength; i < maxLength; i++)
                {
                    zipper.Add(first[i]);
                }
            }
            else if(second.Count > first.Count)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    zipper.Add(second[i]);
                }

            }

            Console.WriteLine(string.Join(" ", zipper));
        }
    }
}
