using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    class Squeek : IQuackBehaviour
    {
        public void PerformAQuack()
        {
            Console.WriteLine("Not a quack... but a squeek!!!");
        }
    }
}
