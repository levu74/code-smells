using System;
using System.Collections.Generic;

namespace CodeSmells.CalculateShapeArea
{
    public class Startup
    {
        public void Run()
        {
            var shapeFactories = new Dictionary<string, IShapeAreaFactory>()
            {
                {"1", new CircleFatory() },
                {"2", new RectangleFactory() },
                {"3", new TrapezoidFactory() }
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter shapes that you want to compute the area:");
                Console.WriteLine("1- Circle");
                Console.WriteLine("2- Rectangle");
                Console.WriteLine("3- Trapezoid");

                Console.Write("Input: ");
                var userInput = Console.ReadLine();
                if (shapeFactories.ContainsKey(userInput))
                {
                    IShapeArea shape = shapeFactories[userInput].Create();
                    Console.WriteLine($"The area of {shape.ShapeName}: {shape.GetArea()}");
                }
                else
                {
                    Console.WriteLine("Invalid input!!!");
                }

                Console.Write("Do you want continue? (y/n): ");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    return;
                } 
            }
        }
    }
}
