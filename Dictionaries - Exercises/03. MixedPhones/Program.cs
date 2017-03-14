using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phoneBook = new Dictionary<string, long>();

            while(input != "Over")
            {
                var first = input.Split(' ')[0];
                var second = input.Split(' ')[2];

                long number;
                if(long.TryParse(second, out number))
                {
                    phoneBook[first] = number;
                }
                else
                {
                    long.TryParse(first, out number);
                    phoneBook[second] = number;
                }

                input = Console.ReadLine();
            }

            var list = phoneBook.Keys.ToList();
            list.Sort();

            foreach(var key in list)
            {
                Console.WriteLine("{0} -> {1}", key, phoneBook[key]);
            }
        }
    }
}
