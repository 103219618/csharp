using System;

namespace task2
{
    class Program
    {
        static void name()
        {
            Console.WriteLine("Please input a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome friend " + name);
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {
            name();
        }
    }
}
