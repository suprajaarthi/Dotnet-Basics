using System;

namespace basicsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            string Phrase = "Giraffe Academy";
            Console.WriteLine(Phrase);
            //Console.ReadLine();
            Console.WriteLine(Phrase.Length);
            //Console.ReadLine();
            Console.WriteLine(Phrase.ToLower());
            //Console.ReadLine();
            Console.WriteLine(Phrase.ToUpper());
            //Console.ReadLine();
            Console.WriteLine(Phrase.Contains("Aca"));
            //Console.ReadLine();
            Console.WriteLine(Phrase[0]);
            Console.WriteLine(Phrase.IndexOf("Acad"));
            //Console.ReadLine();
            Console.WriteLine(Phrase.IndexOf('z'));
            //Console.ReadLine();
            Console.WriteLine(Phrase.Substring(8, 3));
            Console.ReadLine();
        }
    }
}

//Giraffe Academy
//15
//giraffe academy
//GIRAFFE ACADEMY
//True
//G
//8
//-1
//Aca
