using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_DotNet_Practics3
{
    public class FizzBuzz
    {
        public List<string> RunFizzBuzz()
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            return result;
        }
    }

}
