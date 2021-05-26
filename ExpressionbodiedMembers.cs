using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionbodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbersFaster(5, 10));
            SayHi();
            Animals dog = new Animals();
            dog.Name = "Max";
            Console.WriteLine(dog.Name);
        }

        public static void SayHi() => Console.WriteLine("Welcome back Walter");

        public static int AddTwoNumbersFaster(int x, int y) => x + y;

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
    }

    class Animals
    {
        public Animals() => Console.WriteLine("A new animal has been created!");
        

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}
