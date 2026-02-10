using System;

namespace AgeCategorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            if (age < 12)
            {
                Console.WriteLine("You are a Kid");
            }
            else if (age <= 17)
            {
                Console.WriteLine("You are a Teenager");
            }
            else if (age <= 60)
            {
                Console.WriteLine("You are an Adult");
            }
            else
            {
                Console.WriteLine("You are a Senior Citizen");
            }

            Console.ReadKey();
        }
    }
}