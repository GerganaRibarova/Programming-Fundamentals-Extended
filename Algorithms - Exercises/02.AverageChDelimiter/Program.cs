using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageChDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            int numbers = 0;

            for(int i = 0; i < input.Count; i++)
            {
                numbers += input[i].Count();

                foreach (var element in input[i])
                {
                    sum += (int)element;
                }

            }

            char separate = (char)(sum / numbers); 
            if(separate >= 'a' && separate <= 'z')
            {
                separate = (char)(separate - 32);
            }
            Console.WriteLine(string.Join(separate.ToString(),input));
        }
    }
}
