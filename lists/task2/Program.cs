﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberlist = new List<int>();

            System.Console.WriteLine("Please Enter 5 Numbers?");

            int addingNumber = 0;

            while (addingNumber < 5)
            {
                numberlist.Add(int.Parse(Console.ReadLine()));
                addingNumber++;
            }

            System.Console.WriteLine("Thanks :)");
            System.Console.WriteLine("Enter a Number to check against the List?");
            int usernumber = int.Parse(Console.ReadLine());

            int times = 0;
            for (int i = 0; i < numberlist.Count; i++)
            {
                if (usernumber == numberlist[i])
                {
                    times++;
                }
            }

            if (times > 0)
            {
                System.Console.WriteLine(usernumber + " is already entered " + times + " times");
            }

            else
            {
                System.Console.WriteLine("This Number is not in the List");
            }

            Console.ReadKey();
        }
    }
}
