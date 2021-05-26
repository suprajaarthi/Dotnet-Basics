using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
    public delegate void DisplayPlayer(Dictionary<int, string> players);

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listofPlayers = new Dictionary<int, string>();
            listofPlayers.Add(7, "Ronaldo");
            listofPlayers.Add(10, "Messi");
            listofPlayers.Add(8, "Iniesta");

            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);
            player(listofPlayers);
            
        }

        public static void DisplayPlayerInfo(Dictionary<int,string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player no : {player.Key}, Player name : {player.Value}");
            }
        }
    }

}
