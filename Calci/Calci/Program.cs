
using System;
  
namespace Calci
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            {  
                CalCulator cal = new CalCulator();  
                Subtract sub = new Subtract();
                Add ad = new Add();
                Multiply mu = new Multiply();
                Divide div = new Divide();

                Console.WriteLine("Press A for Addition ");
                Console.WriteLine("Press S for Subtraction ");
                Console.WriteLine("Press M for Multiplication ");
                Console.WriteLine("Press D for Division ");
                string op = Console.ReadLine();

                Console.Write("Enter a number : ");
                var num1 = Convert.ToDouble(Console.ReadLine());

            
                Console.Write("Enter a number : ");
                var  num2 = Convert.ToDouble(Console.ReadLine());

                if(op.Equals("A") || op.Equals("a") )
                {
                     Console.WriteLine(ad.Additon(num1,num2));
                }
                else if (op.Equals("S") || op.Equals("s"))
                {
                    Console.WriteLine(sub.Subtraction(num1, num2));
                }

                else if (op.Equals("m") || op.Equals("M"))
                {
                    Console.WriteLine(mu.Multiplication(num1, num2));

                }
                else if (op.Equals("d") || op.Equals("D"))
                {
                    Console.WriteLine(div.Division(num1, num2));

                }
                else
                {
                    Console.WriteLine("Enter valid op");
                }
            }  
        }  
    }  
}  
