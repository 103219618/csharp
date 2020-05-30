using System;
namespace diceroller
{
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
}