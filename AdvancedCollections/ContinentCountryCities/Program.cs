using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentCountryCities
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];
                Add(dictionary, continent, country, city);


            }
            Print(dictionary);

        }

        private static void Add(Dictionary<string, Dictionary<string, List<string>>> dictionary, string continent, string country, string city)
        {
            if (!dictionary.ContainsKey(continent)) dictionary[continent] = new Dictionary<string, List<string>>();
            if (!dictionary[continent].ContainsKey(country)) dictionary[continent][country] = new List<string>();
            dictionary[continent][country].Add(city);
        }

        private static void Print(Dictionary<string, Dictionary<string, List<string>>> dictionary)
        {
            foreach(var continent in dictionary.Keys)
            {
                Console.WriteLine($"{continent}: ");
         
                foreach (var country in dictionary[continent].Keys)
                {
                    Console.WriteLine("  {0} -> {1} ", country, string.Join(", ", dictionary[continent][country]));
                }
            }
        }
    }
}
