using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();

            while(input != "end")
            {
                var first = input.Split(' ')[0];
                var second = input.Split(' ')[2];

                int number;
                if(int.TryParse(second, out number))
                {
                    dictionary[first] = number;
                }
                else
                {
                    if(dictionary.ContainsKey(second))
                    {
                        dictionary[first] = dictionary[second];
                    }
                }

                input = Console.ReadLine();
            }

            foreach(var pair in dictionary)
            {
                Console.WriteLine("{0} === {1}", pair.Key, pair.Value);
            }
        }
    }
}
