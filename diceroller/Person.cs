using System.Collections.Generic;

namespace diceroller
{
    public class Person
    {
        public string Name;
        public List<Die> Dice;

        //constructors
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
            // access the person's dice list --
            // roll each die -> loop --
            // add roll value to a total
            
            int total = 0;

            for (var i = 0; i < this.Dice.Count; i++)
            {
                total += Dice[i].Roll();
            }

            return total; // placeholder
        }

        public void AddNewDie(int sides)
        {
            Die d = new Die(sides);
            this.Dice.Add(d);
        }
    }
}