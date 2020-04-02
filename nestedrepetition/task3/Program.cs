using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "x";
            int counter = 0;

            while (counter < 5)
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

