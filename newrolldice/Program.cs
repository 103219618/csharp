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
            System.Console.WriteLine("4. EXIT");

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

                case "4":
                    System.Console.WriteLine("Thank You For Playing!");
                    Environment.Exit(0);
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
            System.Console.WriteLine("3. Calculate Average");
            System.Console.WriteLine("4. Calculate Total");
            System.Console.WriteLine("5. Main Menu");

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
                    RollAvg();
                    break;

                case "4":
                    RollTotal();
                    break;

                case "5":
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
            lstNew1.Reverse(); //reverses the numbers after sorting

            List<int> lstNew2 = new List<int>();
            lstNew2.AddRange(rollHistory2);
            lstNew2.Sort();  //sorts the numbers
            lstNew2.Reverse();

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
        public void RollAvg()
        {
            int sum1 = 0;
            int avg1 = 0;
            for (int i = 0; i < rollHistory1.Count; i++)
            {
                sum1 += rollHistory1[i];
            }

            avg1 = sum1 / rollHistory1.Count;

            System.Console.WriteLine("Average of Dice 1: " + avg1);

            int sum2 = 0;
            int avg2 = 0;
            for (int i = 0; i < rollHistory2.Count; i++)
            {
                sum2 += rollHistory2[i];
            }

            avg2 = sum2 / rollHistory2.Count;

            System.Console.WriteLine("Average of Dice 2: " + avg2);

            System.Console.WriteLine("Combined Average: " + (avg1 + avg2) / 2);

            ThirdMenu();
        }
        public void RollTotal()
        {
            int sum1 = 0;
            for (int i = 0; i < rollHistory1.Count; i++)
            {
                sum1 += rollHistory1[i];
            }
            System.Console.WriteLine("Total of Dice 1: " + sum1);

            int sum2 = 0;
            for (int i = 0; i < rollHistory2.Count; i++)
            {
                sum2 += rollHistory2[i];
            }
            System.Console.WriteLine("Total of Dice 2: " + sum2);

            System.Console.WriteLine("Total For Both Dice: " + (sum1 + sum2));

            ThirdMenu();
        }

    }

}
