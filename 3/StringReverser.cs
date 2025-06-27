using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class StringReverser
    {
        public string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return new string(s.Reverse().ToArray());
        }
    }

}
