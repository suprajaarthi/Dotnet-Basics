using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "    lord of the RINGS    ";
            // Indexes
            Console.WriteLine(movieName[17]);

            // Trim 
            Console.WriteLine(movieName.Trim());

            // Upper Case
            Console.WriteLine(movieName.ToUpper().Trim());

            // Lower Case
            Console.WriteLine(movieName.Trim().ToLower());

            // Length
            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);


            // Reaplce
            Console.WriteLine(movieName.Replace('l','L').Trim());
        }
    }
}
