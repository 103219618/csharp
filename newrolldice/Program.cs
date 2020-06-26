using System;
using System.Collections.Generic;

namespace newrolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice newDice = new Dice();
            newDice.Menu();
        }


    }

    public class Dice
    {
        public List<int> rollHistory1 = new List<int>();
        public List<int> rollHistory2 = new List<int>();
        public void Roll()
        {
            System.Console.WriteLine("Dice 1 was Rolled " + rollHistory1.Count + " Times!");
            System.Console.WriteLine("Dice 2 was Rolled " + rollHistory2.Count + " Times!");
            Menu();
        }

        public void DiceGen()
        {
            Random rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            System.Console.WriteLine("Dice 1: " + dice1);
            System.Console.WriteLine("Dice 2: " + dice2);
            rollHistory1.Add(dice1);
            rollHistory2.Add(dice2);
            System.Console.WriteLine("Press 1 to Roll Dice Again!!!");
            Menu();
        }
        public void Menu()
        {
            System.Console.WriteLine("Welcome to the Game!");
            System.Console.WriteLine("1. Roll Dice");
            System.Console.WriteLine("2. How Many Times Dice Was Rolled");
            System.Console.WriteLine("3. Stop & Check Dice Rolls");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    DiceGen();
                    break;

                case "2":
                    Roll();
                    break;

                case "3":
                    ThirdMenu();
                    break;

                default:
                    System.Console.WriteLine("Incorrect Selection!");
                    Menu();
                    break;
            }
        }
        public void ThirdMenu()
        {
            System.Console.WriteLine("1. List in Rolled Order");
            System.Console.WriteLine("2. Order Highest to Lowest");
            System.Console.WriteLine("3. Main Menu");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    RollOrder();
                    break;

                case "2":
                    RollOrderhtol();
                    break;

                case "3":
                    Menu();
                    break;

                default:
                    System.Console.WriteLine("Incorrect Selection!");
                    Menu();
                    break;
            }
        }
        public void RollOrder()
        {
            // drawnNo.ForEach(x => { Console.WriteLine(x); });
            System.Console.WriteLine("Dice 1: ");
            foreach (int x in rollHistory1)
            {
                Console.WriteLine(x);
            }

            System.Console.WriteLine("Dice 2: ");
            foreach (int x in rollHistory2)
            {
                Console.WriteLine(x);
            }
            ThirdMenu();
        }
        public void RollOrderhtol()
        {
            List<int> lstNew1 = new List<int>();
            lstNew1.AddRange(rollHistory1);
            lstNew1.Sort(); //sorts the numbers
                            // lstNew2.Reverse(); //reverses the numbers after sorting

            List<int> lstNew2 = new List<int>();
            lstNew2.AddRange(rollHistory2);
            lstNew2.Sort(); //sorts the numbers

            System.Console.WriteLine("Dice 1: ");
            foreach (int x in lstNew1)
            {
                Console.WriteLine(x);
            }

            System.Console.WriteLine("Dice 2: ");
            foreach (int x in lstNew2)
            {
                Console.WriteLine(x);
            }
            ThirdMenu();
        }

    }

}
