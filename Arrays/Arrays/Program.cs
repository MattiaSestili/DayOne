using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            double average;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine("Please enter 5 numbers to be averaged. Press return after each");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                total += numbers[i];
            }

            average = total / (numbers.Length);
            Console.WriteLine("The total is: " + total);
            Console.WriteLine("And the average is: {0:F2}", average);

        }
    }
}
