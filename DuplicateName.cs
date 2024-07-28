using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    public class DuplicateName
    {
        List<string> names = new List<string>
        {
            "John", "Jane", "Doe", "John", "Alice", "Doe", "Bob", "Jane"
        };
        public void method1()
        {
            var duplicates = names
                .GroupBy(name => name)  
                .Where(group => group.Count() > 1)  
                .Select(group => group.Key); 

            Console.WriteLine("Duplicate names:");
            foreach (var name in duplicates)
            {
                Console.WriteLine(name);
            }
        }
    }
}
