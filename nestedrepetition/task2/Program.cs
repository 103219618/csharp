using System;

namespace task2
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
                counter++;
                int counter2 = counter;
                
                while (counter2 < number) {
                    System.Console.Write(name);
                    counter2++;
                }
                System.Console.WriteLine(name);
            }
        }
    }
}

