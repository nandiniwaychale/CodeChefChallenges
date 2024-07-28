using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class MinMaxSalary
    {
        public static void salaryFind()
        {
            Console.WriteLine("Enter the number of employees:");
            int numEmployees = Convert.ToInt32(Console.ReadLine());

            double minSalary = double.MaxValue;
            double maxSalary = double.MinValue;

            for (int i = 1; i <= numEmployees; i++)
            {
                Console.WriteLine($"\nEnter salary for Employee {i}:");
                double salary = Convert.ToDouble(Console.ReadLine());

                if (salary < minSalary)
                {
                    minSalary = salary;
                }
                if (salary > maxSalary)
                {
                    maxSalary = salary;
                }
            }

            Console.WriteLine($"\nMinimum Salary: {minSalary}");
            Console.WriteLine($"Maximum Salary: {maxSalary}");
        }
    }
}
