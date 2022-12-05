using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings! Woohoo!");
        }
    }
}
