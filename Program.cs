using System;

namespace DuckStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -

            // 1. Följ exemplet och skriv koden i denna fil "Strategy Design Pattern.pdf"
            // 2. Rita ditt eget UML diagram i Draw.io som beskriver din kod

            // OBS: Exemplet i pdf filen är skriven i Java... du ska så klart skriva i C#!
            // ///////////////////////////////////////////////////////////////////////////


            // Mallard
            Duck myMallard = new Mallard();
            myMallard.PerformFly();
            myMallard.PerformQuack();
            myMallard.Display();
            Console.WriteLine();

            // RubberDuck
            Duck myRubberDuck = new RubberDuck();
            myRubberDuck.PerformFly();
            myRubberDuck.PerformQuack();
            myRubberDuck.Display();
            Console.WriteLine();

            // ModelDuck
            Duck myModelDuck = new ModelDuck();
            // First the model duck can't fly (it's set to no fly in its ctor)
            myModelDuck.PerformFly();
            // But now we change it flying behaviout to rockets...
            myModelDuck.SetFlyBehaviour(new FlyRocketPowered());
            // now it can fly using rockets...
            myModelDuck.PerformFly();
            myModelDuck.PerformQuack();
            myModelDuck.Display();
        }
    }
}
