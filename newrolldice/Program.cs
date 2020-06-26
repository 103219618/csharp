using System;

namespace newrolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 6);
            System.Console.WriteLine(roll);
            
        }
    }
}
