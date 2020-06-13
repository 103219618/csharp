using System;
using System.Collections.Generic;

namespace bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number: ");
            int upperNo;

            while(!int.TryParse(Console.ReadLine(), out upperNo) || upperNo <0) //checks for positive and numbers only
            {
                System.Console.WriteLine("!!!Please Enter Numbers Only!!!");
            }

            RandomGenerator generator = new RandomGenerator(upperNo);
            //generator.RandomNumber(upperNo);

            //int rand = generator.RandomNumber(1, 100);


            generator.bingoMenu();

        }


    }
}
