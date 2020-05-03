using System;

namespace task8
{
    class Program
    {
        static void MyCode()
        {
            Console.WriteLine("HELLO Coder!!!");

            int num1 = 0;
            int num2 = 1;
            int sum;
            int i;
            int n;

            Console.Write("Input number of Fibonacci Series: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("The Fibonacci series of " + n + " numbers is: ");
            Console.Write(num1 + " " + num2); //prints 0 and 1

            for (i = 2; i < n; i++) //loops starts from 2 because 0 and 1 are printed
            {
                sum = num1 + num2;
                Console.Write(" " + sum);
                num1 = num2;
                num2 = sum;
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyCode();
        }
    }
}
