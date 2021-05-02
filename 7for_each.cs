using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var res=0.0;
            var numbers = new [] {12.7, 10.3, 6.11, 4.4};
            foreach(var num in numbers)
            {
                res+=num;
            }
            
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
