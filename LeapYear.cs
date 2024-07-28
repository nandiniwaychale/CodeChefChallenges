using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class LeapYear
    {
        public static void leapYear()
        {
            Console.WriteLine("Enter a date (yyyy-MM-dd format):");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime date))
            {
                int year = date.Year;
                int month = date.Month;

                bool isLeapYear = DateTime.IsLeapYear(year);

                Console.WriteLine($"\nYear: {year}");
                Console.WriteLine($"Month: {month}");
                Console.WriteLine($"Leap Year: {(isLeapYear ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter date in yyyy-MM-dd format.");
            }
        }
    }
}
