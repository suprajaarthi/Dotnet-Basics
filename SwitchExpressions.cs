using System;

namespace SwitchExpressions
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Months month = Months.August;
            Console.WriteLine(CheckMonthOldWay(month));
            Console.WriteLine(CheckMonth(month));
        }

        public static string CheckMonth(Months month) =>
           month switch
           {
           Months.January => "Winter Month",
           Months.February => "Winter Month",
           Months.March => "Winter Month",
           Months.April => "Spring Month",
           Months.May => "Spring Month",
           Months.June => "Spring Month",
           Months.July => "Summer Month",
           Months.August => "Summer Month",
           Months.September => "Summer Month",
           Months.October => "Autumn Month",
           Months.November => "Autumn Month",
           Months.December => "Winter Month",
           _ => "Invalid input"
           };

    
        public static string CheckMonthOldWay(Months month)
        {

            switch (month)
            {
                case Months.December:
                case Months.January:
                case Months.February:
                case Months.March:
                    return "Winter Month";

                case Months.April:
                case Months.May:
                    case Months.June:
                    return "Spring Month";

                case Months.July:
                case Months.August:
                case Months.September:
                    return "Summer Month";

                case Months.October:
                case Months.November:
                    return "Autumn Month";

                default:
                    return "Invalid input";
            }
        }
    }
}
