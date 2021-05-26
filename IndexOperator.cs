using System;
using System.Collections.Generic;

namespace IndexOperatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new string[] {
            "New York", // 0 - 5
            "Vienna",   // 1 - 4
            "Madrid",   // 2 - 3
            "London",   // 3 - 2
            "Cairo"     // 4 - 1
            };

            Console.WriteLine(cities[cities.Length-1]);
            Console.WriteLine(cities[^2]);

            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine(numbers[^2]);

        }
    }
}
