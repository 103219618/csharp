using System.Collections.Generic;
using System;
namespace diceroller
{
    public class Game
    {
        // 2 players
        Person p1;
        Person p2;

        // constructor
        public Game(string p1Name, string p2Name)
        {
            p1 = new Person(p1Name, new List<Die>());
            p2 = new Person(p2Name, new List<Die>());
        }

        public void Start()
        {
            System.Console.WriteLine("Welcome to Dice Roller");
            System.Console.WriteLine("1. Add Die to Player");
            System.Console.WriteLine("2. Roll Dice");
            System.Console.WriteLine("3. View Player info");
            System.Console.Write("Selection: ");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    // go to the add die menu
                    AddDiceToPlayerMenu();
                    break;
                case "2":
                    // go to the Roll Dice menu
                    break;
                case "3":
                    // view player information
                    ViewPlayerInfo();
                    break;

                default:
                    Start();
                    break;
            }
        }
        public void ViewPlayerInfo()
        {
            System.Console.WriteLine("Pick a player to view (1 or 2)");
            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    System.Console.WriteLine(p1.Name);
                    foreach (var d in p1.Dice)
                    {
                        System.Console.WriteLine(d.NumOfSides);
                    }
                    break;
                case "2":
                    System.Console.WriteLine(p2.Name);
                    foreach (var d in p2.Dice)
                    {
                        System.Console.WriteLine(d.NumOfSides);
                    }
                    break;
            }

            Start();
        }
        public void AddDiceToPlayerMenu()
        {
            System.Console.WriteLine("Pick a Player to add a Dice to (1 or 2)");
            var userSelection = Console.ReadLine();

            System.Console.WriteLine("How many side on the die?");
            var userSides = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case "1":
                    p1.AddNewDie(userSides);
                    break;
                case "2":
                    p2.AddNewDie(userSides);
                    break;
            }

            Start();



        }
    }
}