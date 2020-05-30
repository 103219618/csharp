using System.Collections.Generic;

namespace diceroller
{
    public class Person // class is always starts with capital, variable/method will be capitalised when its public
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
            if (die < 0 && die > this.Dice.Count)
            {
                roll = this.Dice[die].Roll();
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
            // can use for loop if know how may iterations
            // use while loop if dont know how many  iterations
            /*
            int count = 0;
            while (count < this.Dice.Count)
            {
                total += Dice[count].Roll();
                count++;
            }
            
            for (var i = 0; i < this.Dice.Count; i++)
            {
                total += Dice[i].Roll();
            }*/

            // 6 12 20 sided die
            // die = 6 sided die
            foreach(var die in this.Dice) { // the word "die" there can be substituted for anything else, similar to "i"
                total += die.Roll();
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