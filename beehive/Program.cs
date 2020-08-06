using System;
using System.Collections.Generic;

namespace beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            Bees John = new Bees("John", 3);
            Bees Paul = new Bees("Paul", 2);
            Bees George = new Bees("George", 1);
            Bees Ringo = new Bees("Ringo", 2);

            Bees Kurt = new Bees("Kurt", 2);
            Bees Dave = new Bees("Dave", 7);
            Bees Krist = new Bees("Krist", 1);

            BeeHiveList b1 = new BeeHiveList();
            b1.AddBees(John);
            b1.AddBees(Paul);
            b1.AddBees(George);
            b1.AddBees(Ringo);

            BeeHiveList b2 = new BeeHiveList();
            b2.AddBees(Kurt);
            b2.AddBees(Dave);
            b2.AddBees(Krist);

            System.Console.WriteLine("Bees: " + );
        }
    }
}
