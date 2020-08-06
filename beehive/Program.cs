using System;
using System.Collections.Generic;

namespace beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            Bees John = new Bees("John", 3.2F);
            Bees Paul = new Bees("Paul", 2.7F);
            Bees George = new Bees("George", 1.1F);
            Bees Ringo = new Bees("Ringo", 2.0F);
            Bees EXTRA = new Bees("EXTRA", 1.0F);

            Bees Kurt = new Bees("Kurt", 2.3F);
            Bees Dave = new Bees("Dave", 7.4F);
            Bees Krist = new Bees("Krist", 1.5F);

            BeeHiveList b1 = new BeeHiveList();
            b1.AddBees(John);
            b1.AddBees(Paul);
            b1.AddBees(George);
            b1.AddBees(Ringo);
            b1.AddBees(EXTRA);

            BeeHiveList b2 = new BeeHiveList();
            b2.AddBees(Kurt);
            b2.AddBees(Dave);
            b2.AddBees(Krist);

            System.Console.WriteLine("Who Collected Most Honey?");
            System.Console.WriteLine("Bee Hive 1");
            b1.CollectHoney(10);
            System.Console.WriteLine("Bee Hive 2");
            b2.CollectHoney(10);


        }
    }
}
