using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChefPrograms
{
    internal class Vowels
    {
        public int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
