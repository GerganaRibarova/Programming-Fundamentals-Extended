using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var grade = double.Parse(input[1]);
                if (!grades.ContainsKey(name)) grades[name] = new List<double>();
                grades[name].Add(grade);
            }

            foreach(var nameAndGrades in grades)
            {
                Console.WriteLine("{0} -> {1:F2} (avg: {2:F2})",
                    nameAndGrades.Key, 
                    string.Join(" ", nameAndGrades.Value.Select(p => string.Format("{0:F2}", p))),
                    nameAndGrades.Value.Average());
            }

        }
    }
}
