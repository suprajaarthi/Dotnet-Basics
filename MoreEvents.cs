using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Football info = new Football();
            info.DisplayClub("Manchester United", "England");
            info.DisplayPlayerInformation("Ronaldo", "Real Madrid"); 
        }
    }

    class Football
    {
        private DisplayInformation displayInfoInstance;

        public Football()
        {
            displayInfoInstance = new DisplayInformation();
            displayInfoInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent;
            displayInfoInstance.DisplayMessageBeforeEvent += DisplayInfoInstance_DisplayMessageBeforeEvent;
            
        }

        private void DisplayInfoInstance_DisplayMessageBeforeEvent()
        {
            Console.WriteLine("Program is about to display information...");
        }

        private void DisplayInfoInstance_DisplayDateAfterEvent()
        {
            Console.WriteLine("Information has been displayed on " + DateTime.Now.ToShortTimeString());
        }

        public void DisplayClub(string club, string country)
        {
            displayInfoInstance.DisplayClub(club, country);
        }

        public void DisplayPlayerInformation(string name, string club)
        {
            displayInfoInstance.DisplayPlayer(name, club);
        }
    }

    class DisplayInformation
    {

        public delegate void DisplayDateAfterDelegate();
        public delegate void DisplayMessageBeforeDelegate();

        public event DisplayDateAfterDelegate DisplayDateAfterEvent;
        public event DisplayMessageBeforeDelegate DisplayMessageBeforeEvent;

        public void DisplayClub(string clubName, string country)
        {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{clubName} from {country}");
            DisplayDateAfterEvent(); Console.WriteLine();
        }

        public void DisplayPlayer(string playerName, string clubName)
        {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{playerName} plays for {clubName}");
            DisplayDateAfterEvent();
        }
    }
}
