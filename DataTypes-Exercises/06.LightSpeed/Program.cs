﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal lightYearInKm = 9450000000000M;
            decimal speedOfLight = 300000M;

            decimal total = (lightYearInKm / speedOfLight) * lightYears;


            TimeSpan diff = TimeSpan.FromSeconds((double)total);
            Console.WriteLine("{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                  diff.Days / 7,
                  diff.Days % 7,
                  diff.Hours,
                  diff.Minutes,
                  diff.Seconds);

        }
    }
}