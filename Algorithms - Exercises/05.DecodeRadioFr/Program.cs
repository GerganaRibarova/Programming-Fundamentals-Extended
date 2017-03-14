using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFr
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
         
            var word = new List<char>();

            for(int i = 0; i < input.Count; i++)
            {
                string[] frequence = new string[2];
                frequence = input[i].Split('.');
                char left = char.Parse(frequence[0]);
                char right = char.Parse(frequence[1]);
                if (left != '0') word.Insert(i, left);
                if (right != '0') word.Insert(word.Count - i, right);
            }

            Console.WriteLine(string.Join("", word));
        }
    }
}
