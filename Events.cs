using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void myDelegate(string name);

    class Program
    {
        public event myDelegate myEvent;

        public Program()
        {
            myEvent += new myDelegate(SayHiEnglish);
            myEvent += new myDelegate(SayHiArabic);
            myEvent += new myDelegate(SayHiItalian);
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.myEvent("Jack");
        }

        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        public void SayHiArabic(string name)
        {
            Console.WriteLine("Marhaaban " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Caio " + name);
        }
    }
}
