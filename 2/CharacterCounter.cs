using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics2
{
    
    public class CharacterCounter
    {
        public Dictionary<char, int> CountCharacters(string input)
        {
            Dictionary<char, int> res = new Dictionary<char, int>();
            char[] chars = input.ToCharArray();
            char[] charWithoutRepeats = chars.Distinct().ToArray();

            foreach (char c in charWithoutRepeats)
            {
                res[c] = chars.Count(f => f == c);
            }
            
            return res;
        }
    }

}
