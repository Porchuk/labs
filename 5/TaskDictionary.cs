using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public class TaskDictionary
    {
        public void UpdateDictionary(Dictionary<string, int> stock, string product, int amount)
        {
            if (stock.ContainsKey(product))
                stock[product] += amount;
            else
                stock[product] = amount;
        }
    }
}
