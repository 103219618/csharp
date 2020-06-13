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
                Console.WriteLine(drawnNo.Count);
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


                    default:
                        System.Console.WriteLine("Thank you for playing!");
                        break;
                }

            }
        }
}