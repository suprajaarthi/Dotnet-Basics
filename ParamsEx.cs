using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(10, 50, 25, 3);

            LoopThroughArray("Ahmad", "Ned", "Emma");

            LoopThroughArray(DateTime.Now, new DateTime(2017, 10, 10));
        }

        public static void LoopThroughArray<T>(params T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
        }
    }
}
