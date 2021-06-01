using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "Piano";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;
            while(guess != secretword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess : ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if(outOfGuesses)
            {
                Console.Write("You Lose");
            }
            else
            {
                Console.Write("You Win!!!");
            }

        }
        

        
    }
}


//Enter guess : Pia
//Enter guess : Pian
//Enter guess : Piano
//You Win!!!
