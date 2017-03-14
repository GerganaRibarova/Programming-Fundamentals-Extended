using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToCharArray();

            var letters = new Dictionary<char, int>();

            foreach(var letter in input)
            {
                if(!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 1);
                }
                else
                {
                    letters[letter]++;
                }
            }

            foreach(var letter in letters)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }
        }
    }
}
