using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class EmpSorting
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
        public static void sortingFun()
        {
            List<EmpSorting> employees = new List<EmpSorting>
            {
              new EmpSorting { Id = 101, Name = "Nandini" },
              new EmpSorting { Id = 103, Name = "Anjali" },
              new EmpSorting { Id = 102, Name = "Tanisha" },
              new EmpSorting { Id = 104, Name = "Roshani" }
           };
            Console.WriteLine("Choose sorting criteria:");
            Console.WriteLine("1. Sort by Name");
            Console.WriteLine("2. Sort by ID");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose sorting order:");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            int order = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (order == 1) 
                {
                    employees.Sort((emp1, emp2) => emp1.Name.CompareTo(emp2.Name));
                }
                else if (order == 2) 
                {
                    employees.Sort((emp1, emp2) => emp2.Name.CompareTo(emp1.Name));
                }
            }
            else if (choice == 2) 
            {
                if (order == 1) 
                {
                    employees.Sort((emp1, emp2) => emp1.Id.CompareTo(emp2.Id));
                }
                else if (order == 2)
                {
                    employees.Sort((emp1, emp2) => emp2.Id.CompareTo(emp1.Id));
                }
            }
            Console.WriteLine("\nSorted Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
