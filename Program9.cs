using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an Even number.");
            }
            else
            {
                Console.WriteLine(number + " is an Odd number.");
            }

            Console.ReadKey();
        }
    }
}