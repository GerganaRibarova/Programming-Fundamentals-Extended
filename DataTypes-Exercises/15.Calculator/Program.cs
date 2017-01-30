using System;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0 ;

            switch(operation)
            {
                case '+':
                    c = a + b; break;
                case '-':
                    c = a - b; break;
                case '*':
                    c = a * b; break;
                case '/':
                    c = a / b; break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", a, operation, b, c);
        }
    }
}
