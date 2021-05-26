using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();
        }

        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            SayHi(name);
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Welcome back, {name}");
        }
    }
}
