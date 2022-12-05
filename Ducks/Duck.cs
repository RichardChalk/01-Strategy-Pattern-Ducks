using System;
using System.Collections.Generic;
using System.Text;

namespace DuckStrategy
{
    // We cannot make a Duck as this class is abstract!
    public abstract class Duck
    {
        // These 2 Interface instances will be inherited by all ducks
        public IFlyBehaviour _flyBehaviour;
        public IQuackBehaviour _quackBehaviour;

        // Abstract so it MUST be implemented by sub classes!
        public abstract void Display();

        // This will now call the correct method by delegating to the correct class
        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.PerformAQuack();
        }

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            _flyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            _quackBehaviour = qb;
        }


        public void Swim()
        {
            Console.WriteLine("All ducks can float.... even rubber ones!");
        }
    }
}
