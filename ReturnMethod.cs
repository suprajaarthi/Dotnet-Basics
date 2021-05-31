using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            //cube(5);
            Console.WriteLine(cube(5));

        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}

//125
