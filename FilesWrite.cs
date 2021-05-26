using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Directory.CreateDirectory(@"C:\files\males");
            string file = @"C:\files\males\Names.txt";
            StreamWriter sw = new StreamWriter(file,true);
            sw.WriteLine("John");
            sw.WriteLine("Ahmad");

            sw.Close();
        }
    }
}
