using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayString
{
    class Program
    {
        static void Main(string[] args)
        {
           var array = Console.ReadLine().Split(' ').ToArray();

           bool swapped = false;
           string swap;

            do
            {
                swapped = false;
                for(int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i].CompareTo(array[i+1]) > 0)
                    {
                        swap = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swap;
                        swapped = true;
                    }
                }

            } while (swapped);
            
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
