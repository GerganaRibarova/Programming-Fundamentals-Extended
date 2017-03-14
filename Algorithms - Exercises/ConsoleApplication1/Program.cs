using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input = string.Empty;
            var lastRemoved = 0;

            while(input != "stop")
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else if (input != "bang")
                {
                    int num = int.Parse(input);
                    list.Insert(0, num);
                }
                else if (input == "bang" && list.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastRemoved);
                    break;
                }
                else
                {
                    double average = list.Sum() / list.Count;
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= average)
                        {
                            lastRemoved = list[i];
                            list.RemoveAt(i);
                            Console.WriteLine("shot {0}", lastRemoved);
                            for(int j = 0; j < list.Count; j++)
                            {
                                list[j]--;
                            }
                            break;
                        }
                    }
                }

            }

            if (list.Count > 0)
            {
                var survivor = string.Join(" ", list);
                Console.WriteLine($"survivors: {survivor}");
            }
            else if (list.Count == 0 && input == "stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }

        }
    }
}
