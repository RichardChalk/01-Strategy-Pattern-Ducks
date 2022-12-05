using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _quackBehaviour = new Quack();
            _flyBehaviour = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Show the Model duck... pretty right?");
        }
    }
}
