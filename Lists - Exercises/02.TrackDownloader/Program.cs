using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklisted = Console.ReadLine()
                .Split(' ')
                .ToList();
            
            var filenames = new List<string>();
            var song = Console.ReadLine();
            bool isThere = false;
            while(song != "end")
            {
                for (int j = 0; j < blacklisted.Count; j++)
                {
                    if (song.Contains(blacklisted[j])) isThere = true;
                }

                if (isThere == false) filenames.Add(song);
                isThere = false;
                song = Console.ReadLine();
            }

            filenames.Sort();

            foreach(string word in filenames)
            {
                Console.WriteLine(word);
            }
        }
    }
}
