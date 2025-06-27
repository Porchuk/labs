using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics2
{
    public class EvenNumberSum
    {
        public int CalculateEvenSum(int n)
        {
            int res = 0;
            for (int i = 0; i <= n; i+=2)
            {
                res += i;
            }
            return res;
        }
    }

}
