using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Even Numbers
            //for (int x = 0; x < 501; x++)
            //{
            //    if(x%2==0)
            //        Console.Write(x + ", ");
            //}

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
