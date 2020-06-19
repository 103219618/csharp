using System;
using System.Collections.Generic;

namespace bingo
{
    public class RandomGenerator
    {
        public int upperNumber;

        public List<int> drawnNo = new List<int>();

        public RandomGenerator(int upperNo)
        {
            this.upperNumber = upperNo;
        }

        Random random = new Random();
        public void RandomNumber()
        {
            if (drawnNo.Count == this.upperNumber)
            {
                System.Console.WriteLine("!!!All Numbers Drawn, Cannot Draw Duplicate Numbers!!!");
            }
            else
            {

                int rand;
                do
                {
                    rand = random.Next(1, this.upperNumber + 1);
                } while (drawnNo.Contains(rand));
                drawnNo.Add(rand);
            }
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
                    System.Console.WriteLine("Thank You for Playing!");
                    Environment.Exit(0); //was getting error so had to add this to force exit
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
            // drawnNo.ForEach(x => { Console.WriteLine(x); }); //displays numbers from list
            // ViewDrNo();

            

            foreach (int x in drawnNo)
            {
                Console.WriteLine(x);
            }
            ViewDrNo();

            /* int i;
            for (i = 1; i <= 10; i++)
            {
                System.Console.WriteLine(i);
            }
            ViewDrNo(); */

        }
        public void ViewDrNo2()
        {
            List<int> lstNew = new List<int>();
            lstNew.AddRange(drawnNo);

            lstNew.Sort(); //sorts the numbers
            lstNew.ForEach(x => { Console.WriteLine(x); }); //displays numbers from list
            ViewDrNo();
        }

        public void CheckSpNo()
        {
            Console.Write("Enter a Number to Check OR Press 'M' to go back to Bingo Menu: ");
            string userNumber = Console.ReadLine();

            while (userNumber.ToUpper() != "M")
            {
                int specificNumber = int.Parse(userNumber);
                if (this.drawnNo.Contains(specificNumber))
                {
                    System.Console.WriteLine("Yay! Number is in the List!");

                    CheckSpNo();
                }
                else
                {
                    System.Console.WriteLine("Oops! Number is not in the list");

                    CheckSpNo();
                }
            }
            bingoMenu();

        }
    }
}