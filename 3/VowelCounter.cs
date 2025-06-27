using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class VowelCounter
    {
        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return input.Count(c => vowels.Contains(c));
        }
    }

}
