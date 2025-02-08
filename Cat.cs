using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cat: Animal
    {
        public Cat() : base("katu") { }



        public override void MakeSound()
        {
            Console.WriteLine("katun asum e Myauuuuu- Mrrr pisooo!!!");
        }
    }
}
