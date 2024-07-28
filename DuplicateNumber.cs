using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    public  class DuplicateNumber
    {
      public void FindDuplicates(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key} is duplicated {pair.Value} times");
                }
            }
        }
    }
}
