using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public class TaskQueue
    {
        public void ProcessQueue(Queue<string> tasks)
        {
            while (tasks.Count > 0)
            {
                string task = tasks.Dequeue();
                Console.WriteLine("Processing task: " + task);
            }
        }
    }
}
