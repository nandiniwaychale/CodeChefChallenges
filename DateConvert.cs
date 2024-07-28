using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class DateConvert
    {
        public static void function()
        {
            Console.WriteLine("Enter a date/time in string format (e.g., '2024-07-28' or '15:30:00'):");
            string input = Console.ReadLine();

            if (IsDate(input))
            {
                if (DateTime.TryParse(input, out DateTime date))
                {
                    Console.WriteLine($"Input '{input}' is a valid date.");
                    Console.WriteLine($"Converted to time format: {date.ToString("HH:mm:ss")}");
                }
                else
                {
                    Console.WriteLine($"Input '{input}' is not a valid date.");
                }
            }
            else if (IsTime(input))
            {
                if (DateTime.TryParseExact(input, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime time))
                {
                    Console.WriteLine($"Input '{input}' is a valid time.");
                    Console.WriteLine($"Converted to date format: {time.ToString("yyyy-MM-dd")}");
                }
                else
                {
                    Console.WriteLine($"Input '{input}' is not a valid time.");
                }
            }
            else
            {
                Console.WriteLine($"Input '{input}' does not match expected date or time format.");
            }
        }
        static bool IsDate(string input)
        {
            return Regex.IsMatch(input, @"^\d{4}-\d{2}-\d{2}$");
        }
        static bool IsTime(string input)
        {
            return Regex.IsMatch(input, @"^\d{2}:\d{2}:\d{2}$");
        }
    }
}
