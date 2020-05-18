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

            Console.WriteLine();
        }
    }

    public class Die
    {
        public int NumOfSides;  //attributes

        //constructor (instantiates the object, creates the object from the class. If we dont create constructor, it automatically creates for us)
        // same as class name including name casing
        public Die(int numofsides)
        {
            this.NumOfSides = numofsides;
        }

        // default constructor (no parameters)
        public Die()
        {
            this.NumOfSides = 6;
        }

        //method
        public int Roll()
        {
            return 0; //placeholder
        }
    }

    public class Person
    {
        public string Name;
        public List<Die> Dice;

        //constructor
        public Person(string name, List<Die> dice)
        {
            this.Name = name;
            this.Dice = dice;
        }

        public Person()
        {
            this.Name = "John Doe";
            this.Dice = new List<Die>();
        }

        // methods
        public int Roll(int die)
        {
            return 0; //placeholder
        }
        public int RollAllDice()
        {
            return 0;
        }
    }
}
