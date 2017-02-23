using System;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phone = Console.ReadLine().Split(' ');
            string[] name = Console.ReadLine().Split(' ');
            string input = Console.ReadLine();
            while(input != "done")
            {
                for(int i=0; i < phone.Length; i ++)
                {
                    if (input == name[i]) Console.WriteLine("{0} -> {1}", name[i], phone[i]);
                }

                input = Console.ReadLine();
            }
        }
    }
}
