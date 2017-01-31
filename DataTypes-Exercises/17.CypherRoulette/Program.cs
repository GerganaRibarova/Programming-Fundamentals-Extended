using System;

namespace _17.CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string finalText = "";
            string areSame = "";

            for(int i = 0; i < n; i ++)
            {
                string word = Console.ReadLine();
                if(word == areSame)
                {
                    finalText = "";
                }

                areSame = word;

            }
        }
    }
}
