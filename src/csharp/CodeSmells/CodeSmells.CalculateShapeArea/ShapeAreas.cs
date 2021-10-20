using System;

namespace CodeSmells.CalculateShapeArea
{
    public interface IShapeArea
    {
        string ShapeName { get; }
        double GetArea();
    }

    internal class Circle : IShapeArea
    {
        public Circle(double radius, int roundDecimal)
        {
            Radius = radius;
            RoundDecimal = roundDecimal;
            ShapeName = nameof(Circle);
        }

        public double Radius { get; }
        public int RoundDecimal { get; }
        public string ShapeName { get; }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), RoundDecimal);
        }
    }

    internal class Rectangle : IShapeArea
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            ShapeName = nameof(Rectangle);
        }

        public double Length { get; }
        public double Width { get; }

        public string ShapeName { get; }

        public double GetArea()
        {
            return Length * Width;
        }
    }

    internal class Trapezoid : IShapeArea
    {
        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
            ShapeName = nameof(Trapezoid);
        }

        public double Base1 { get; }
        public double Base2 { get; }
        public double Height { get; }
        public string ShapeName { get; }


        public double GetArea()
        {
            return (Base1 + Base2) * Height / 2;
        }
    }
}
