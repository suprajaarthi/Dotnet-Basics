using System;
using System.Collections.Generic;

namespace nullcoalassignapp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int? i = null;
            //i = 5;
            //numbers ??= new List<int>();
            //numbers.Add(i!.Value);
            numbers.Add(i ??= 17);
            //numbers.Add(i ??= 20);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }    
            Console.WriteLine(i);  // output: 17
        }
    }
}
