using System;

namespace task3
{
    class Program
    {
        static void sum()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int add = num1 + num2;
            
            Console.WriteLine("The sum of two numbers is: " + add);
        }
        static void Main(string[] args)
        {
            sum();
        }
    }
}
