using System;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        { 

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i ++)
            {
                string result = Console.ReadLine();
                if(result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Showsuccess(operation, message);
                }
                else if(result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
            }
        }

        static void Showsuccess(string operation, string message)
        {
            Console.WriteLine( $"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: { message}.");
        }

        static void ShowError(string operation, int code)
        {
            string reason;
            if (code > 0) reason = "Invalid Client Data";
            else reason = "Internal System Failure";

            Console.WriteLine($"Error: Failed to execute { operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
    }
}
