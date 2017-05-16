using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    class DateConverter
    {
        private static string GetOrdinalSuffix(int num)
        {
            if (num.ToString().EndsWith("11")) return "th";

            if (num.ToString().EndsWith("12")) return "th";

            if (num.ToString().EndsWith("13")) return "th";

            if (num.ToString().EndsWith("1")) return "st";

            if (num.ToString().EndsWith("2")) return "nd";

            if (num.ToString().EndsWith("3")) return "rd";

            return "th";
        }

        public void createNewDate(int day, int month, int year)
        {
            string newdate = day+DateConverter.GetOrdinalSuffix(day);
            Console.WriteLine(newdate + ", "+ month + ", " + year);

        }

        public void convertString(DateConverter dateConvert)
        {
            
            
            string myDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(myDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            dateConvert.createNewDate(date.Day, date.Month, date.Year);
        }

        static void Main(string[] args)
        {
            DateConverter dateConvert = new DateConverter();
            Console.WriteLine("Please Enter date using dd/mm/yyyy format");

            for (;;)
            {
                try
                {
                    dateConvert.convertString(dateConvert);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter date using dd/mm/yyyy format");
                }
            }
            Console.ReadLine();
        }
    }
}
