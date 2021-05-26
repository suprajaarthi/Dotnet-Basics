using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddTwoNumbers;
            Console.WriteLine(AddTwoNumbers(3, 10));

            Func<int> funcTwo = AddTwoNumbers;
            Console.WriteLine(funcTwo()); 
            
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 5;

            z = x + y;

            return z;
        }

    }
}
