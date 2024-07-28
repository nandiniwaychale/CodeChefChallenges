using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class FindAge
    {
        public static void ageFind()
        {
            Console.WriteLine("Enter your date of birth (yyyy-MM-dd):");
            string dobString = Console.ReadLine();

            if (DateTime.TryParse(dobString, out DateTime dob))
            {
                int age = CalculateAge(dob);
                Console.WriteLine($"Your age is: {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter date in yyyy-MM-dd format.");
            }
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
