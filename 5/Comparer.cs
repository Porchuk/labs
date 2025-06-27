using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public class Comparer
    {
        public static bool AreEqual<T>(T x, T y)
        {
            return x.Equals(y);
        }
    }
}
