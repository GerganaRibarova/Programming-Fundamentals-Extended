using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();

            foreach(var word in words)
            {
                if(!result.ContainsKey(word))
                {
                    result.Add(word, 1);
                }
                else
                {
                    result[word]++;
                }
            }

            var oddNumberWords = new List<string>();
            foreach(var kvp in result)
            {
                if (kvp.Value % 2 != 0) oddNumberWords.Add(kvp.Key);
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }

}
