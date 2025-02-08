using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Animal : IMakeSound
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();


    }
}
