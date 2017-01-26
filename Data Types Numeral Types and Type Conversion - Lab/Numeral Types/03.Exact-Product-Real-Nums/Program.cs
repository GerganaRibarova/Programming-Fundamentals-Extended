using System;


namespace _03.Exact_Product_Real_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 1;
            for(int i = 0; i < n; i ++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum *= num;
            }
            Console.WriteLine(sum);
        }
    }
}
