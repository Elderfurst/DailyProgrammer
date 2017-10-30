using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer
{
    public class Easy338 : IRunnable
    {
        public void Run()
        {
            string[] dates = new string[]
            {
                "2017 10 30",
                "2016 2 29",
                "2015 2 28",
                "29 4 12",
                "570 11 30",
                "1066 9 25",
                "1776 7 4",
                "1933 1 30",
                "1953 3 6",
                "2100 1 9",
                "2202 12 15",
                "7032 3 26"
            };

            foreach (var date in dates)
            {
                Console.WriteLine(GetDayOfWeek(date));
            }
        }

        private static string GetDayOfWeek(string date)
        {
            var brokenDate = date.Split(' ');
            var parsedDate = new
            {
                Year = brokenDate[0],
                Month = brokenDate[1],
                Day = brokenDate[2]
            };
            int dayNum = ZellersCongruence(int.Parse(parsedDate.Year), int.Parse(parsedDate.Month),
                int.Parse(parsedDate.Day));
            if (dayNum < 0)
            {
                dayNum += 7;
            }
            switch (dayNum)
            {
                case 0:
                    return "Saturday";
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                default:
                    return "Unknown";
            }
        }

        private static int ZellersCongruence(int year, int month, int day)
        {
            if (month < 3)
            {
                year--;
                month += 12;
            }
            return (day + ((13 * (month + 1)) / 5) + (year % 100) + ((year % 100) / 4) + ((year / 100) / 4) - (2 * (year / 100))) % 7;
        }
    }
}
