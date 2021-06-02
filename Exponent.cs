using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }

        static int GetPow(int baseNum , int pow)
        {
            int res = 1;
            for(int i=0;i<pow;i++)
            {
                res =res * baseNum;

            }
            return res;
        }

    }
}
