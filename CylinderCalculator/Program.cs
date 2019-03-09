using System;

namespace CylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cylinder Calculator 1.0!");

            Console.Write("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsAString);

            Console.Write("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.141592654;

            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            Console.WriteLine($"The cylinder's volume is: {volume} cubic units.");
            Console.WriteLine($"The cylinder's surface area is: {surfaceArea} square units.");

            Console.ReadKey();
        }
    }
}
