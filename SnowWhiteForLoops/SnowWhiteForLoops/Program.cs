using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhiteForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            string dinner;
            string answer;
            string drink;

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                dinner = sevenDwarves[i] + " What do you want for dinner? ";
                Console.WriteLine(dinner);
                answer = Console.ReadLine();
                Console.WriteLine(sevenDwarves[i] + " your " + answer + " is ready");
            }

            foreach (string dwarf in sevenDwarves)
            {
                Console.WriteLine(dwarf + " What do you want as drink?");
                drink = Console.ReadLine();
                Console.WriteLine(dwarf + " your " + drink + " is ready");
            }
        }
    }
}
