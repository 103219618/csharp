using System;
using System.Collections.Generic;

namespace newrolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dice();
            Menu();
        }
        public static void Roll()
        {

        }

        public static void Dice()
        {
            List<int> rollHistory = new List<int>();
            Random rand = new Random();
            int dice = rand.Next(1, 6);
            System.Console.WriteLine(dice);
            rollHistory.Add(dice);
            System.Console.WriteLine(rollHistory.Count);

        }
        public static void Menu()
        {
            System.Console.WriteLine("Welcome to the Game!");
            System.Console.WriteLine("1. Roll Dice");
            System.Console.Write("How Many Times Dice Was Rolled: " + rollHistory.Count);

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    Dice();
                    break;
            }
        }
    }
}
