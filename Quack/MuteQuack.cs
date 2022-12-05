using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class MuteQuack : IQuackBehaviour
    {
        public void PerformAQuack()
        {
            Console.WriteLine("Silence... no quack!");
        }
    }
}
