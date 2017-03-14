using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var users = new Dictionary<string, string>();
            var unsuccessful = 0;

            while(input != "login")
            {
                var user = input.Split(' ')[0];
                var password = input.Split(' ')[2];
                users[user] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while(input != "end")
            {
                var user = input.Split(' ')[0];
                var password = input.Split(' ')[2];
                if (users.ContainsKey(user) || users.ContainsValue(password)) Console.WriteLine($"{user}: logged in successfully");
                else
                {
                    Console.WriteLine("{0}: login failed", user);
                    unsuccessful++;
                }
            }

            Console.WriteLine("unsuccessful login attempts: {0}", unsuccessful);
        }
    }
}
