using System;

namespace VerbatimInterpolatedStringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string normalString = "Vienna is a very beautiful city. \nI visited it multiple times.";

            string verbatimString = @"Vienna is a very beautiful city.
I visited it multiple times.";

            Console.WriteLine(normalString);
            Console.WriteLine(verbatimString);
            Console.WriteLine();

            int visits = 2;

            string concatenation = "I visited Vienna " + visits + " times";

            string format = string.Format("I visited Vienna {0} times", visits);

            string interpolate = $"I visited Vienna {visits} times";

            Console.WriteLine(concatenation);
            Console.WriteLine(format);
            Console.WriteLine(interpolate);


            string fileName = "";
            string fileName1 = @"c:\Documents\files\FileNo10.txt";
            string fileName2 = "c:\\Documents\\files\\FileNo10.txt";

            string fileName3 = @"c:\Documents\files\" + fileName + ".txt";
            string fileName4 = $@"c:\Documents\files\{fileName}.txt";

            Console.WriteLine(fileName3);
            Console.WriteLine(fileName4);

            string travelToVienna = $@"Vienna is a very beautiful city.
I visited it {visits} times.";

            Console.WriteLine(travelToVienna);

            string[] @for = { "Jack","Jennifer","Smith"};
            foreach (var name in @for)
            {
                Console.WriteLine(name);
            }
        }
    }
}
