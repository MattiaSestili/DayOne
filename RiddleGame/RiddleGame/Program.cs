using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RiddleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            string rightFirstAnswer = "a stamp";
            string rightSecondAnswer = "mushroom";
            char giveUp = 'N';

            Match match = Regex.Match(rightFirstAnswer, "stamp",RegexOptions.IgnoreCase);
            Match match2 = Regex.Match(rightSecondAnswer, "mushroom", RegexOptions.IgnoreCase);

            while (giveUp == 'N')
            {
                Console.WriteLine("What can travel around the world while staying in a corner?");
                userAnswer = (Console.ReadLine()).ToLower();

                if ((userAnswer == rightFirstAnswer) || (match.Success))
                {
                    Console.WriteLine("Well Done I have another riddle for you:");
                    giveUp = 'Y';
                }
                else
                {
                    Console.WriteLine("I'm sorry you're wrong!! Do you want to try again? Y/N");
                    giveUp = Convert.ToChar(Console.ReadLine());
                }

            }

            do
            {
                Console.WriteLine("The second riddle is: What kind of room has no doors or windows?");
                userAnswer = (Console.ReadLine()).ToLower();

                if ((rightSecondAnswer == userAnswer) || (match2.Success))
                {
                    Console.WriteLine("Well Done!");
                }
                else
                {
                    Console.Write("Wrong!! Try again");
                }

            } while ((userAnswer == rightFirstAnswer) && (giveUp == 'N'));
            
        }
    }
}
