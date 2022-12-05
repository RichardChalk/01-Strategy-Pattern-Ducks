using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class Quack : IQuackBehaviour
    {
        public void PerformAQuack()
        {
            Console.WriteLine("A real quack!!");
        }

    }
}
