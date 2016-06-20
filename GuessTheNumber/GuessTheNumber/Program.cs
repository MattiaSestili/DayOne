using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            Random randomNumber = new Random();
            int numberToGuess = randomNumber.Next(30);
            char newTry;
            char userInput = 'N';

            do
            {
                Console.WriteLine("Guess the number I'm thinking of, please insert a number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == numberToGuess)
                {
                    Console.WriteLine("Well Done!! The number to guess was: " + numberToGuess + "\nDo you want to play again? Y/N");
                    userInput = Convert.ToChar(Console.ReadLine());
                    newTry = char.ToUpper(userInput);
                    numberToGuess = randomNumber.Next(30);
                }
                else if (userNumber > numberToGuess)
                {
                    Console.WriteLine("Your number is greater than number I'm thinking of. \nDo you want to try again? Y / N");
                    userInput = Convert.ToChar(Console.ReadLine());
                    newTry = char.ToUpper(userInput);
                }
                else if (userNumber < numberToGuess)
                {
                    Console.WriteLine("Your number is less than number I'm thinking of. \nDo you want to try again? Y / N");
                    userInput = Convert.ToChar(Console.ReadLine());
                    newTry = char.ToUpper(userInput);
                }
            } while (userInput != 'N');
        }
    }
}
