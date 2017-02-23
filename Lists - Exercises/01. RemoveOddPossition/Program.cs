using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveOddPossition
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToList();

            var print = new List<string>();
            for(int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0) print.Add(words[i]);
            }

            foreach(string word in print)
            {
                Console.Write(word);
            }
        }
    }
}
