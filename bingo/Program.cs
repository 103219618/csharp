using System;
using System.Collections.Generic;

namespace bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int upperNo = Convert.ToInt32(Console.ReadLine());
            RandomGenerator generator = new RandomGenerator();
            generator.RandomNumber(upperNo);

            //int rand = generator.RandomNumber(1, 100);
            Console.WriteLine($"Random number is {generator.drawnNo[0]}");

            generator.bingoMenu();

        }
        public class RandomGenerator
        {
            int upperNumber;

            public List<int> drawnNo = new List<int>();

            Random random = new Random();
            public void RandomNumber(int upNo)
            {
                this.upperNumber = upNo;
                int rand;
                rand = random.Next(1, upperNumber);
                drawnNo.Add(rand);
            }

            public void bingoMenu()
            {
                System.Console.WriteLine("Welcome to the Swinburne Bingo Club");
                System.Console.WriteLine("1. Draw next number");
                System.Console.WriteLine("2. View all drawn numbers");
                System.Console.WriteLine("3. Check specific number");
                System.Console.WriteLine("4. Exit");
                System.Console.Write("Selection: ");

            }
        }

    }
}
