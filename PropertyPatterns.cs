using System;

namespace PropertyPatternsApp
{
     public enum Cities
    {
        Vienna,
        Berlin,
        Amsterdam,
        Madrid,
        Budapest,
        Paris,
        London,
        Warsaw,
        Prague,
        Melbourne
    }
    public class City
    {
        public Cities CityName { get; set; }
        public string CountryName { get; set; }

        public City(Cities city, string country)
        {
            CityName = city;
            CountryName = country;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            City viennaAus = new City(Cities.Vienna, "Austria");
            City parisFr = new City(Cities.Paris, "France");
            City parisUS = new City(Cities.Paris, "US");

            Console.WriteLine(CheckPrices(viennaAus));
            Console.WriteLine(CheckPrices(parisFr));
            Console.WriteLine(CheckPrices(parisUS));
        }

        public static string CheckPrices(City location) =>
          location switch
          {
              { CityName: Cities.Warsaw } => "Reasonable",
              { CityName: Cities.Budapest } => "Reasonable",
              { CityName: Cities.Vienna } => "Above Average",
              { CityName: Cities.Paris, CountryName: "US" } => $"{location.CityName}, {location.CountryName} Reasonable",
              { CityName: Cities.Paris, CountryName: "France" } => "High",

              _ => "Invalid Input"
          };
    }
}
