using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            string input = Console.ReadLine();
            double radius = Convert.ToDouble(input);

            double area = Math.PI * radius * radius;

            Console.WriteLine("The Area of the circle is: " + area);
            
            Console.ReadKey();
        }
    }
}