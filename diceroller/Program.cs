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

            for (int i = 0; i < 20; i++)
            {
                // roll william wallace's second die
                Console.WriteLine(p1.RollDie(1));
            }

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
            Random rand = new Random();
            int roll = rand.Next(1, this.NumOfSides + 1); // (1,7) NO as not all dice are 6 sided dice

            return roll; //placeholder
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
        /// rolls a spcific die from the Dice List. PARAMETER: indexing starts at 0

        public int RollDie(int die)
        {
            int roll = -1; // if die is out of range will return -1
            if (die < 0 && die > Dice.Count)
            {
                roll = Dice[die].Roll();
            }
            return roll; //placeholder
        }


        // roll all of the player's dice once and return the total (TASK)
        public int RollAllDice()
        {
            return 0; // placeholder
        }

        public void AddNewDie(int sides)
        {
            Die d = new Die(sides);
            this.Dice.Add(d);
        }
    }
}
