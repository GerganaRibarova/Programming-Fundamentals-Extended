using System;

namespace _01.BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            BlankReceipt();
        }

        static void BlankReceipt()
        {
            Header();
            Body();
            Footer();
        }

        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}

