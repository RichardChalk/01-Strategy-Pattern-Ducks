using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class FlyRocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rockets baaby!");
        }
    }
}
