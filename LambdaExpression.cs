using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);    

    class Program
    {
        static void Main(string[] args)
        {
            //Multiply MultiplyNumber = delegate (int n) { { return n * 3; } };
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(30));


            //DisplayMessage Message = delegate { Console.WriteLine("Hi from the anonymous method"); };
            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            Message();
            
        }
    }
}
