using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> bookList = new List<String>()
            { "The Wind in the Willows", "The Sun Also Rises", "Alice's Adventures in Wonderland" };

            Console.WriteLine("There is a list of books available. Choose your option: A add a book to list, D delete and L to show the list and Q for exit");

            string userChoice = Console.ReadLine().ToUpper();

            do
            { 
                switch (userChoice)
                {
                    case "A":
                        Console.WriteLine("Enter the book you want to add to the list: ");
                        bookList.Add(Console.ReadLine());
                        break;
                    case "D":
                        Console.WriteLine("Enter the book you want to delete to the list: ");
                        bookList.Add(Console.ReadLine());
                        break;
                    case "L":
                        Console.WriteLine("These are the books in the list: ");
                        foreach (string book in bookList)
                        {
                            Console.WriteLine(book);
                        }
                        break;
                    case "Q":
                        Console.WriteLine("You are going to exit, see you later.");
                        break;
                    default:
                        Console.WriteLine("Your choice is not valid, try again entering A,D,L or Q");
                        break;
                }

                Console.WriteLine("Make another choice: A add a book to list, D delete and L to show the list and Q for exit");

                userChoice = Console.ReadLine().ToUpper();

            } while (userChoice != "Q");
        }
    }
}
