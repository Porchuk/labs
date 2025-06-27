using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        void Start();
    }

    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting.");
        }
    }
}
