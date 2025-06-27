using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }

    public class SimpleLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Info: " + message);
        }

        public void LogError(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
