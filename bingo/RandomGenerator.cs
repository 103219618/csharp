using System;
using System.Collections.Generic;

namespace bingo
{
    public class RandomGenerator
    {
        int upperNumber;

        public List<int> drawnNo = new List<int>();

        public RandomGenerator(int upperNo)
        {
            this.upperNumber = upperNo;
        }

        Random random = new Random();
        public void RandomNumber()
        {

            int rand;
            rand = random.Next(1, upperNumber);
            drawnNo.Add(rand);
            bingoMenu();
        }

        public void bingoMenu()
        {
            System.Console.WriteLine("Total Numbers Drawn: " + drawnNo.Count);
            System.Console.WriteLine("Welcome to the Swinburne Bingo Club");
            System.Console.WriteLine("1. Draw next number");
            System.Console.WriteLine("2. View all drawn numbers");
            System.Console.WriteLine("3. Check specific number");
            System.Console.WriteLine("4. Exit");
            System.Console.Write("Selection: ");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    // go to the add menu
                    RandomNumber();
                    break;

                case "2":
                    ViewDrNo();
                    break;

                case "3":
                    CheckSpNo();
                    break;

                case "4":
                    System.Console.WriteLine("Thank you for playing!");
                    Environment.Exit(0);
                    break;


                default:
                    System.Console.WriteLine("Incorrect Selection!");
                    bingoMenu();
                    break;
            }

        }
        public void ViewDrNo()
        {
            System.Console.WriteLine("1. View Drawn Numbers");
            System.Console.WriteLine("2. View Drawn Numbers in Ascending Order");
            System.Console.WriteLine("3. Go to Main Menu");
            System.Console.Write("Selection: ");

            var userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    // go to the add menu
                    ViewDrNo1();
                    break;

                case "2":
                    ViewDrNo2();
                    break;

                case "3":
                    bingoMenu();
                    break;


                default:
                    System.Console.WriteLine("Incorrect Selection!");
                    ViewDrNo();
                    break;
            }

        }
        public void ViewDrNo1()
        {
            drawnNo.ForEach(x => { Console.WriteLine(x); }); //displays numbers from list
            ViewDrNo();
        }
        public void ViewDrNo2()
        {
            drawnNo.Sort(); //sorts the numbers
            drawnNo.ForEach(x => { Console.WriteLine(x); }); //displays numbers from list
            ViewDrNo();
        }

        public void CheckSpNo()
        {
            Console.Write("Enter a Number to Check or Press 'M' to go back to Bingo Menu: ");
            string userNumber = Console.ReadLine();

            while (userNumber.ToUpper() != "M")
            {
                int specificNumber = int.Parse(userNumber);
                if (this.drawnNo.Contains(specificNumber))
                {
                    System.Console.WriteLine("Number is in the list");

                    CheckSpNo();
                }
                else
                {
                    System.Console.WriteLine("Oh-Number not is the list");

                    CheckSpNo();
                }
            }
            bingoMenu();

        }
    }
}