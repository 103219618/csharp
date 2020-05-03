using System;

namespace task6
{
    class Program
    {
        static void swap()
        {
            int num1;
            int num2;
            int newnum;

            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            newnum = num1;
            num1 = num2;
            num2 = newnum;

            Console.WriteLine("Now the 1st number is: " + num1 + " and the 2nd number is: " + num2);
        }
        static void Main(string[] args)
        {
            swap();
        }
    }
}
