using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynum = { 4, 8, 15, 16, 23 };

            for (int i=0; i <= luckynum.Length;i++)
            {
                Console.WriteLine(luckynum[i]);
            }
        }
    }
}
