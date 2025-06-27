using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class SumCalculator
    {
        public int SumOfEvens(int n)
        {
            int sum = 0;
            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }

}
