using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "x";
            int counter = 0;
            Console.WriteLine ("Enter Number");
            int number = Int32.Parse(Console.ReadLine());

            while (counter < number)
            {
                int counter2 = 0;
                while (counter2 <= counter)
                {
                    Console.Write(name);
                    counter2++;
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}

