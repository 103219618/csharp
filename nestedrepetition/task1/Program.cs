using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "x";
            int counter = 0;

            while (counter < 5)
            {
                counter++;
                int counter2 = counter;

                while (counter2 < 5)
                {
                    System.Console.Write(name);
                    counter2++;
                }

                System.Console.WriteLine(name);

            }
        }
    }
}

