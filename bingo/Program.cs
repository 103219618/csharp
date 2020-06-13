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
            RandomGenerator generator = new RandomGenerator(upperNo);
            //generator.RandomNumber(upperNo);

            //int rand = generator.RandomNumber(1, 100);


            generator.bingoMenu();

        }


    }
}
