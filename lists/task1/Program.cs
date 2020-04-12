using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //add number
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            System.Console.WriteLine("Please Enter a Number:");
            int usernumber = int.Parse(Console.ReadLine());

            if (numbers.Contains(usernumber))
            {
                System.Console.WriteLine("This Number has been previously entered");
            }
            else
            {
                System.Console.WriteLine("This Number is not in the list");
            }

            Console.ReadKey();

        }
    }
}
