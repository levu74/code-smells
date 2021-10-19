using CodeSmells.CalculateShapeArea;
using System;

namespace CodeSmells.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculateShapeArea = new CodeSmells.CalculateShapeArea.Startup();
            calculateShapeArea.Run();
        }
    }
}
