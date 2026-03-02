using System;

class Program
{
    static void Main()
    {
        int max = Int32.MinValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int currentNumber = Convert.ToInt32(Console.ReadLine());

            if (currentNumber > max)
            {
                max = currentNumber;
            }
        }

        Console.WriteLine("Maximum number is: " + max);
    }
}