using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(),out int x);
            if (x == 0)
            {
                Console.WriteLine("This is not a valid input");
            }
            else
            {
                Console.WriteLine("You have entered no. " + x);
            }
        }
    }
}
