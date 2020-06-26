using System;
using System.Collections.Generic;

namespace newrolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Roll()
        {
            System.Console.WriteLine("Dice was Rolled " + rollHistory.Count + " Times!");
            Menu();
        }

        public static void Dice()
        {
            List<int> rollHistory = new List<int>();
            Random rand = new Random();
            int dice = rand.Next(1, 6);
            System.Console.WriteLine(dice);
            rollHistory.Add(dice);
            Menu();

        }
        public static void Menu()
        {
            System.Console.WriteLine("Welcome to the Game!");
            System.Console.WriteLine("1. Roll Dice");
            System.Console.WriteLine("2. How Many Times Dice Was Rolled: ");
            System.Console.WriteLine("3. Stop & Check Dice Rolls");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    Dice();
                    break;

                case "2":
                    Roll();
                    break;

                default:
                    System.Console.WriteLine("Incorrect Selection!");
                    Menu();
                    break;
            }
        }
    }
}
