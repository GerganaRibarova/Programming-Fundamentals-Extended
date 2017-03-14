using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            int i = 0;
            bool lastBomb = false;

            while(energy > 0)
            {
                string[] commandParams = commands[i].Split('|');
                string currentCommand = commandParams[0];
                lastBomb = false;

                if(currentCommand == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                int value = int.Parse(commandParams[1]);

                switch(currentCommand)
                {
                    case "Left":
                        i = Math.Abs(i - value) % commands.Count;
                        energy -= value;
                        break;
                    case "Right":
                        i = (i + value) % commands.Count;
                        energy -= value;
                        break;
                    case "Bomb":
                        commands.RemoveAt(i);
                        i = 0;
                        energy -= value;
                        lastBomb = true;
                        break;
                       
                }

                if(commands[commands.Count - 1] != "RabitHole")
                {
                    commands.RemoveAt(commands.Count - 1);
                }
                commands.Add("Bomb|" + energy);
            }

            if(lastBomb && energy <= 0)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if(energy <= 0 && !lastBomb)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
