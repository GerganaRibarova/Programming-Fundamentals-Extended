﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');


            var counts = new SortedDictionary<double, int>();


            foreach (var num in nums)


                double parsedNum = double.Parse(num);


            if (counts.ContainsKey(parsedNum))


                counts[parsedNum]++;


            else


                counts[parsedNum] = 1;


            foreach (var num in counts.Keys)


                Console.WriteLine($"{num} -> {counts[num]}");
        }
    }
}
