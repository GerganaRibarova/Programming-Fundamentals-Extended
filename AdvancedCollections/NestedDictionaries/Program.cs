using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var population = new Dictionary<string, Dictionary<string, int>>();
            AddPopulation(population, "USA", "New York", 1000000);
        }

        private static void AddPopulation(Dictionary<string, Dictionary<string, int>> population, string country, string town, int townPopulation)
        {
            if(!population.ContainsKey(country))
            {
                population[country] = new Dictionary<string, int>();
            }
            population[country][town] = townPopulation;
        }
    }
}
