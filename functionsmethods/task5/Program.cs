using System;

namespace task5
{
    class Program
    {
        static void arrays()

        {
            int[] a = new int[1000000];
            int e = 5;

            int i, sum = 0;

            Console.WriteLine("Input 5 elements in the array:");
            for (i = 0; i < e; i++)

            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < e; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("The sum of the elements of the array is " + sum);
        }
        static void Main(string[] args)
        {
            arrays();
        }
    }
}