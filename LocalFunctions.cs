using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformMathOperations(1, 2, 3,4);
            PerformMathOperations(5, 20);
        }

        public static void PerformMathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());
            int AddNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number;
                }
                return result;
            }

            Console.WriteLine("Multi = " + MultiNumebrs());
            int MultiNumebrs()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
            Console.WriteLine("----------");
        }
        
    }
}
