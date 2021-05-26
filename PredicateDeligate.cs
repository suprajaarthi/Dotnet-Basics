using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> checkIfAvailable = isAdmin;

            Console.WriteLine(checkIfAvailable(50)); 
        }

        public static bool isAdmin(int empNo)
        {
            if (empNo == 10)
                return true;
            else
                return false;
        }
    }
}
