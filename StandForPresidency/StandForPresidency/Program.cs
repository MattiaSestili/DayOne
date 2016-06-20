using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandForPresidency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barack Obama, Donald Trump, Hilary Clinton, Ben Carson They are standing for the US Presidency\nWho do you think will win?");
            string userChoice = (Console.ReadLine()).ToLower();
            string reply;

            switch(userChoice)
            {
                case "barack obama":
                case "barack":
                case "obama":
                    reply = "Honestly I like him";
                    Console.WriteLine(reply);
                    break;
                case "donald trump":
                case "trump":
                case "donald":
                    reply = "It will be a terrible choice";
                    Console.WriteLine(reply);
                    break;
                case "hilary Clinton":
                case "clinton":
                case "hilary":
                    reply = "I'm not feel confortable with her as US President";
                    Console.WriteLine(reply);
                    break;
                case "ben Carson":
                case "carson":
                case "ben":
                    reply = "Yeah might be, I don't know him";
                    Console.WriteLine(reply);
                    break;
                default:
                    reply = "Really??? You are not reading the news about it";
                    Console.WriteLine(reply);
                    break;
            }
        }
    }
}
