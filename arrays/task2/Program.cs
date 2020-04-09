using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] numbers = new int[size];

            numbers[0] = 34;
            numbers[1] = 5;
            numbers[2] = 67;
            numbers[3] = 1;
            numbers[4] = 99;
            numbers[5] = 34;
            numbers[6] = 44;
            numbers[7] = 78;
            numbers[8] = 34;
            numbers[9] = 0;

            int index = 0;

            while (index < size)
            {
                System.Console.WriteLine(numbers[index]);

                index++;
            }

            System.Console.WriteLine("------");

            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            System.Console.WriteLine("= " + total);
        }
    }
}
