using System;

namespace CodeSmells.CalculateShapeArea
{
    internal interface IShapeAreaFactory
    {
        IShapeArea Create();
    }

    internal class CircleFatory : IShapeAreaFactory
    {
        public IShapeArea Create()
        {
            Console.WriteLine("Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            return new Circle(r, 2);
        }
    }

    internal class RectangleFactory : IShapeAreaFactory
    {
        public IShapeArea Create()
        {
            Console.WriteLine("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            return new Rectangle(length, width);
        }
    }

    internal class TrapezoidFactory : IShapeAreaFactory
    {
        public IShapeArea Create()
        {
            Console.WriteLine("First base: ");
            double base1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second base: ");
            double base2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            return new Trapezoid(base1, base2, height);
        }
    }
}
