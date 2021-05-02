using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12.7, 10.3, 6.11, 4.4};
            var res = numbers[0];
            res+=numbers[1];
            res+=numbers[2];
            Console.WriteLine(res);
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
