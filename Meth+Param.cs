using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayhi("Cat");
            Sayhi("Bat");
            Sayhi("Dog");
            Console.ReadLine();

        }
        static void Sayhi(string name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
}

//Hello Cat
//Hello Bat
//Hello Dog

