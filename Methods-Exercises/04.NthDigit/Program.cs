using System;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(num, index));
        }

        static int FindNthDigit(long num, int index)
        {
            int br = 1;
            while(num != 0)
            {
                if(index == br)
                {
                    num = num % 10;break;
                } 
                else
                {
                    num = num / 10;
                    br++;
                }
            }
            return (int)num;
        }
    }
}
