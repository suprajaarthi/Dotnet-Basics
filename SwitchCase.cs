using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(4));
            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesay";
                    break;
                case 2:
                    dayName = "Wednedday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Monday";
                    break;

                
            }
            return dayName;

        }
    }
}
//Friday
