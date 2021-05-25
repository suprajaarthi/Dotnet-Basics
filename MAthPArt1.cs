using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.227;
            // ceiling
            Console.WriteLine("Ceiling : " + Math.Ceiling(x));
            // floor
            Console.WriteLine("Floor : " + Math.Floor(x));
            // round
            Console.WriteLine("Round : " + Math.Round(x,2));
            //truncate
            Console.WriteLine("Truncate : " + Math.Truncate(x));
        }
    }
}
