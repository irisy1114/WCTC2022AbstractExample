using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Duck : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("quack quack");
        }

        public override void Sleep()
        {
            Console.WriteLine("QQZZZZzzzz");
        }
    }
}
