using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void SayHiDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);
            sayHi += new SayHiDelegate(SayHiJapanese);
            sayHi += new SayHiDelegate(SayHiItalian);
            sayHi += new SayHiDelegate(SayHiGerman);
            sayHi += new SayHiDelegate(SayHiArabic);

            sayHi();
        }

        // Say hi in English
        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there.");
        }

        // Say hi in Spanish
        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola.");
        }

        // Say hi in Italian
        public static void SayHiItalian()
        {
            Console.WriteLine("Ciao.");
        }

        // Say hi in German
        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo.");
        }

        // Say hi in Arabic (مرحباً)
        public static void SayHiArabic()
        {
            Console.WriteLine("Marhabaan.");
        }

        // Say hi in Japanese (こんにちは)
        public static void SayHiJapanese()
        {
            Console.WriteLine("Kon'nichiwa");
        }
    }
}
