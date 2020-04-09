using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Please Enter Name!");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("======================");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello " + names[i]);
            }

        }
    }
}
