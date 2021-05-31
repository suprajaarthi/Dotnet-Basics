using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayhi("Cat",21);
            Sayhi("Bat", 7); Sayhi("Jack", 20);
            Console.ReadLine();

        }
        static void Sayhi(string name,int age)
        {
            Console.WriteLine("Hello "+name +" your age is "+age);
        }
    }
}


Hello Cat your age is 21
Hello Bat your age is 7
Hello Jack your age is 20
