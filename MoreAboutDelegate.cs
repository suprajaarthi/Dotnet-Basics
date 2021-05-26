using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDelegates
{
    // void delegate with one string argument and one int
    public delegate void PlayerInformationWithGoals(string playerName, int playerGoals);

    // string delegate with one int argument and one string
    public delegate string PlayerInformationBasedOnNumberAndClub(int playerNo,string club, string country = "Unknown");


    class Program
    {
        static void Main(string[] args)
        {            
            PlayerInformationWithGoals playerOne = new PlayerInformationWithGoals(DisplayInformation);            
            PlayerInformationBasedOnNumberAndClub playerTwo = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);

            //playerOne("Ronaldo", 50);
            //playerTwo(7, "Real Madrid","Portugal");

            Console.WriteLine(playerTwo.Method);

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType.Name}, {item.Name}, {item.Position}, {item.IsOptional}, {item.DefaultValue} ");
            }
        }


        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals);
        }

        public static string DisplayInformation(int number,string club,string country = "Unknown")
        {
            // Some logic goes in here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    } 
}
