using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            numbers.AddRange(array);

            System.Console.WriteLine("Please Enter a Number?");
            int usernumber = int.Parse(Console.ReadLine());

            if (numbers.Contains(usernumber))
            {
                System.Console.WriteLine("This Number has been previously entered");
            }
            else
            {
                System.Console.WriteLine("This Number is not in the list");
            }
            Console.ReadKey();
        }
    }
}