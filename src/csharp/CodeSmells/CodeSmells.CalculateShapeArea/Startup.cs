using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells.CalculateShapeArea
{
    public class Startup
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter shapes that you want to compute the area:");
                Console.WriteLine("1- Circle");
                Console.WriteLine("2- Rectangle");
                Console.WriteLine("3- Trapezoid");
                Console.WriteLine("0- Exit");

                Console.Write("Input: ");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1": // Circle
                        Console.WriteLine("Radius: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of circle whose radius is {r}: { 3.14 * Math.Pow(r, 2)}");
                        break;
                    case "2": // Rectangle
                        Console.WriteLine("Length: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Width: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of rectangle: {length * width}");
                        break;
                    case "3": // Trapezoid
                        Console.WriteLine("First base: ");
                        double base1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Second base: ");
                        double base2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Height: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"The area of Trapezoid: {(base1 + base2) * height/2 }");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input!!!");
                        break;
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
