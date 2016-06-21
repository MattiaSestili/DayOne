using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

            codingLanguages.Add("C#", "The best language in the world");
            codingLanguages.Add("Java", "Oracle language nice and easy");
            codingLanguages.Add("C++", "Apple app is based on this");

            Console.WriteLine(
            "The dictionary list is a list of coding language, choice a letter for an action:\nA for add a language, R for delete it, C for count the list");
            Console.WriteLine("K for search into the list bye Key value and Q for quit");
            string userChoice = Console.ReadLine().ToUpper();

            string userInput;
            string userInput2;
            string userSearch;
            int dictionaryLenght;

            do
            {
                switch (userChoice)
                {
                    case "A":
                        Console.WriteLine("please put a key:");
                        userInput = Console.ReadLine();
                        Console.WriteLine("please put a description:");
                        userInput2 = Console.ReadLine();
                        codingLanguages.Add(userInput, userInput2);
                        break;
                    case "R":
                        Console.WriteLine("please enter the value you want to remove:");
                        userInput = Console.ReadLine();
                        codingLanguages.Remove(userInput);
                        break;
                    case "C":
                        dictionaryLenght = codingLanguages.Count;
                        Console.WriteLine("the lenght of the dictionary is: " + dictionaryLenght);
                        break;
                    case "K":
                        userSearch = Console.ReadLine();
                        if (codingLanguages.ContainsKey(userSearch))
                        {
                            string value = codingLanguages[userSearch];
                            Console.WriteLine(value);
                        }
                        else
                        {
                            Console.WriteLine("The language you are looking for is not present in the List");
                        }
                        break;
                    case "Q":
                        Console.WriteLine("You are going outside the program");
                        break;

                    default:
                        Console.WriteLine("Your choice is not valid");
                        break;
                }

                Console.WriteLine("Take another choice: A for add a language, R for delete it, C for count the list, K for search into the list bye Key value, D for search by description and Q for quit");
                userChoice = Console.ReadLine().ToUpper();

            } while (userChoice != "Q");
        }
    }
}
