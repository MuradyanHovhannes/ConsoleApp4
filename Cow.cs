using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cow:Animal
    {
        public Cow() : base("kov") { }

        public override void MakeSound()
        {
            Console.WriteLine("kovy asum e Muuuuuuuuuuuuu!!!");
        }
    }
}
