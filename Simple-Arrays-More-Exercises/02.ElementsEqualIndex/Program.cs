using System;

namespace _02.ElementsEqualIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int[] nums = new int[values.Length];
            for(int i = 0; i < values.Length; i ++)
            {
                nums[i] = int.Parse(values[i]);
                if (nums[i] == i) Console.Write("{0} ", i);
            }
        }
    }
}
