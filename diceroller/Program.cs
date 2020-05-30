using System;
using System.Collections.Generic;

namespace diceroller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die();
            Die d2 = new Die(12);
            Die d3 = new Die(20);

            List<Die> diceList1 = new List<Die>();
            diceList1.Add(d1);
            diceList1.Add(d2);
            diceList1.Add(d3);

            List<Die> diceList2 = new List<Die>();
            diceList2.Add(d2);

            Person p1 = new Person("william wallace", diceList1);
            Person p2 = new Person("Joan of Arc", diceList2);

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Dice.Count);

            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Dice.Count);
            p2.AddNewDie(18);

            Console.WriteLine(p2.Dice.Count);

            var rollVal = p1.RollAllDice();
            Console.WriteLine(rollVal);

        }
    }
}
