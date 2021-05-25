using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;
            x = rand.Next(1,13);
            Console.WriteLine("Month : " + x);

            double y = 0;
            y = rand.NextDouble() * 10;
            Console.WriteLine("Random double no is " + Math.Round(y,2));
        }
    }
}
