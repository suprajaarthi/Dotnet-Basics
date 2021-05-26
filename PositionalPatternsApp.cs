using System;

namespace PositionalPatternsApp
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }
    class Program
    {
        static string DisplayPosition(Point point) => point switch
        {
            (0, 0) => "Origin",
            var (x, y) when x > 0 && y > 0 => $"Current Position is {x},{y}",
            _ => "Unknown Position"
        };
        static void Main(string[] args)
        {

            Point start = new Point(0, 0);
            Console.WriteLine(DisplayPosition(start));
            start = new Point(10, 30);
            Console.WriteLine(DisplayPosition(start));
        }
    }
    }
