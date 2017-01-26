using System;

namespace _01.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int num = 1; num <= n; num++)
            {
                int digit = num;
                int sum = 0;
                bool special = false;
                 while(digit != 0)
                {
                     sum += digit % 10;
                    digit = digit / 10;
                }
                 if (sum == 5 || sum == 7 || sum == 11) special = true;
                Console.WriteLine("{0} -> {1}",num,special);
            }

        }
    }
}
