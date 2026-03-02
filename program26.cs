using System;

class Program
{
    static void Main()
    {
        int min = Int32.MaxValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int currentNumber = Convert.ToInt32(Console.ReadLine());

            if (currentNumber < min)
            {
                min = currentNumber;
            }
        }

        Console.WriteLine("Minimum number is: " + min);
    }
}