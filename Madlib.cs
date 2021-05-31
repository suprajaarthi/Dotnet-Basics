using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color :");
            color = Console.ReadLine();

            Console.Write("Enter a pluralNoun :");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity :");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are"+ color);
            Console.WriteLine(pluralNoun +"are blue");
            Console.WriteLine("I love "+celebrity);


        }
    }
}

//Enter a color :Magenta
//Enter a pluralNoun :Microwave
//Enter a celebrity :MotherTerasa
//Roses areMagenta 
//Microwave are blue
//I love MotherTerasa
