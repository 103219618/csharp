using System;

namespace task12opt
{
    class Program
    {
        static int fib(int n)
        {
            if (n <= 2)
                return 1;

            else
                return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The Fibonacci of " + num + "th term is " + fib(num));
        }
    }
}
