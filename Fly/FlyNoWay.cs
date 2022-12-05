using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Sorry I can't fly!!!");
        }
    }
}
