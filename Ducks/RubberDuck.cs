using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _quackBehaviour = new Squeek();
            _flyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Show the rubber duck... pretty right?");
        }
    }
}
