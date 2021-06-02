using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Cannot divide by 0");
            }
            
        }

    }
}
//OP:

//Enter a number :7
//Enter another number : 0
//Cannot divide by 0
