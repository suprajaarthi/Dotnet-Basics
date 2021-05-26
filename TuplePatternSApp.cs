using System;

namespace TuplePatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPrices("Paris", "", ""));
            Console.WriteLine(CheckPrices("Paris", "US", "English"));
        }

        public static string CheckPrices(string city, string country, string language) =>
         (city, country, language) switch
         {
             ("Vienna", "Austria", "German") => "Above Average",
             ("Paris", "France", "French") => "High",
             ("Paris", "US", "English") => "Reasonable",
             ("Paris", _, _) => "High",
             (_, _, _) => "Invalid Input"
         };

        public static string CheckPrices(string city, string country) =>
           (city, country) switch
           {
               ("Vienna", "Austria") => "Above Average",
               ("Paris", "France") => "High",
               ("Paris", "US") => "Reasonable",
               (_, _) => "Invalid Input"
           };
    }
}
