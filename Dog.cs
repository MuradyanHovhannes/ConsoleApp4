using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class Dog:Animal
    {
        public Dog() : base("shun") { }

        public override void MakeSound()
        {
            Console.WriteLine("shuny asum e haf-haf!!! RRRR");
        }
    }
}
