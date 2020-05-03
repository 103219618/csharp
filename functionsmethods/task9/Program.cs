using System;

namespace task9
{
    class Program
    {
        static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;

            Console.Write("Input a number: ");
            n = int.Parse(Console.ReadLine());

            if (chkprime(n))
            {
                Console.WriteLine(n + " is a prime number");
            }

            else
            {
                Console.WriteLine(n + " is not a prime number");
            }
            Console.WriteLine();
        }
    }
}
