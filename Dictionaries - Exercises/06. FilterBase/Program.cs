using System;
using System.Collections.Generic;

namespace _06.FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = new Dictionary<string, int>();
            var salary = new Dictionary<string, double>();
            var position = new Dictionary<string, string>();

            var input = Console.ReadLine();
            while(input != "filter base")
            {
                var separate = input.Split();
                var first = separate[0];
                var second = separate[separate.Length - 1];

                int parsedAge;
                double parsedSalary;

                if (int.TryParse(second, out parsedAge)) age[first] = parsedAge;
                else if (double.TryParse(second, out parsedSalary)) salary[first] = parsedSalary;
                else position[first] = second;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var kvp in age)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Salary")
            {
                foreach (var kvp in salary)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine("Salary: {0:F2}", kvp.Value);
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Position")
            {
                foreach (var kvp in position)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
