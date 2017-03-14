using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            List<string> words = new List<string>();
            List<int> nums = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                
                if(words.Contains(input[i]))
                {
                    int wordIndex = words.IndexOf(input[i]);
                    nums[wordIndex]++;
                }
                else
                {
                    words.Add(input[i]);
                    nums.Add(1);
                }
            }

            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    if (nums[i] < nums[i+1])
                    {
                        int swap = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = swap;
                        swapped = true;

                        string swapWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = swapWord;
                    }
                }

            } while (swapped);

            int sum = nums.Sum();   
            for(int i = 0; i < words.Count; i ++)
            {
                double percentage = nums[i] * 100.0 / sum;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i], nums[i], percentage);
            }

        }
    }
}
