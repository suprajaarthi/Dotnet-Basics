using System;
using System.Collections.Generic;

namespace rangeapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new string[] {
                "New york", //0 - 5
                "Vienna",   //1 - 4
                "Madrid",   //2 - 3
                "London",   //3 - 2
                "Cairo"     //4 - 1  
            };

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //var copyCities = cities[0..5];
            //var copyCities = cities[^5..^2];
            var copyCities = cities[..];
            Console.WriteLine("\n-----\n");
            foreach (var newCity in copyCities)
            {
                Console.WriteLine(newCity);
            }
            Range citiesRange = 0..5;
            Console.WriteLine(citiesRange.GetType());

            Console.WriteLine(citiesRange.Start);
            Console.WriteLine(citiesRange.End);

            var listOfCities = cities[citiesRange];
            foreach (var newCity in listOfCities)
            {
                Console.WriteLine(newCity);
            }
           
        }
    }
}
