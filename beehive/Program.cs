using System;
using System.Collections.Generic;

namespace beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            Bee John = new Bee(3);
            Bee Paul = new Bee(2);
            Bee George = new Bee(1);
            Bee Ringo = new Bee(2);

            Bee Kurt = new Bee(2);
            Bee Dave = new Bee(7);
            Bee Krist = new Bee(1);

            Beehive b1 = new Beehive();
            b1.AddBees(John);
            b1.AddBees(Paul);
            b1.AddBees(George);
            b1.AddBees(Ringo);

            Beehive b2 = new Beehive();
            b2.AddBees(Kurt);
            b2.AddBees(Dave);
            b2.AddBees(Krist);
        }
    }
}
