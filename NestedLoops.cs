using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                //Console.WriteLine("First loop i = " + i);
                for (int j = 1; j <= 30; j++)
                {
                    Console.Write("0 ");
                    //Console.WriteLine("Second loop j = " + j);
                }
                Console.WriteLine();
            }
        }
    }
}
