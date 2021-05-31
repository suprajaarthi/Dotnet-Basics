using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;

            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else 
            {
                Console.WriteLine("You are a short female");
            }
            Console.ReadLine();
        }
        
    }
}

//You are a short male
