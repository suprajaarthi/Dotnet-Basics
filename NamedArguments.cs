using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation(country: "Portugal", playerName: "Ronaldo", playerGoals: 55, playerNo: 7);
        }

        public static void DisplayPlayerInformation(int playerNo, string playerName, int playerGoals,string country = "Unknown")
        {
            Console.WriteLine(playerNo);
            Console.WriteLine(playerName);
            Console.WriteLine(playerGoals);
            Console.WriteLine(country);
        }
    }
}
