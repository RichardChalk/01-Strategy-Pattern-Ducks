using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    public class Mallard : Duck
    {
        public Mallard()
        {
            _quackBehaviour = new Quack();
            _flyBehaviour = new FlyWithWings();
        }
        
        public override void Display()
        {
            Console.WriteLine("Show the Mallard duck... pretty right?");
        }
    }
}
