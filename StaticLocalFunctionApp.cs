using System;

namespace StaticLocalFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {4, 6, 5 };
            AddNumbers();
            
             void AddNumbers()
            {
                numbers[2] = 1;
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();

            string firstName = "Clark";
            string lastName = "Kent";
            Console.WriteLine(GetName(firstName, lastName));
            //string GetName() => firstName + " " + lastName;
            static string GetName(string first, string last) => first + " " + last;
        }
    }
}
