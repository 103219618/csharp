using System;

namespace task11opt
{
    class Program
    {
        static decimal factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * factorial(num - 1);
            }
        }
        static void Main(string[] args)
        {
            int nmbr;
            decimal d;

            Console.WriteLine("Enter a number: ");
            nmbr = int.Parse(Console.ReadLine());

            d = factorial(nmbr);
            Console.WriteLine("The factorial of " + nmbr + "! is " + d);

        }
    }
}
