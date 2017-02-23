using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            string[] numsString = Console.ReadLine().Split(' ');
            int[] nums = new int[numsString.Length];

            for (int i = 0; i < numsString.Length; i++)
            {
                nums[i] = Int32.Parse(numsString[i]);

                if(nums[i] % 2 == 0)
                {
                    int a = (int)(symbols[i] - nums[i]);
                    Console.Write((char)a);
                }
                else
                {
                    int a = (int)(symbols[i] + nums[i]);
                    Console.Write((char)a);
                }
            }


        }
    }
}
