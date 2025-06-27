using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow";
        }
    }

}
