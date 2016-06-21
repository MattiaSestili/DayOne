using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "apple", "orange", "kiwi" };
            Console.WriteLine("Insert a value in the array:");
            string user = Console.ReadLine();
           
            try
            {
                myArray[3] = user;
            }
            catch (Exception e)
            {
                Console.WriteLine("The thrown e is went good: the banana's index doesn't exist", e);
            }

        }
    }
}
