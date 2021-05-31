using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(20, 10));
            Console.ReadLine();
        }
        static int GetMax(int num1 , int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else 
            {
                result = num2;
            }

            return result;
        }
        
    }
}

// 20 
