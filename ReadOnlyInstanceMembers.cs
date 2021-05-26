using System;

namespace ReadonlyInstanceMembersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 2;
            point.Y = 4;
            Console.WriteLine(point.DisplayPosition());
        }
    }
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly string DisplayPosition() =>
            $"({X},{Y}) is {Distance} from origin";
    }
}
