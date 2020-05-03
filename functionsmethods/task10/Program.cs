using System;

namespace task10
{
    class Program
    {
        static int totCal(int n)
        {
            string n1 = Convert.ToString(n);
            int tot = 0;
            for (int i = 0; i < n1.Length; i++)
                tot = tot + int.Parse(n1.Substring(i, 1));
            return tot;
        }
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the digits of the number " + num + " is: " + totCal(num));

        }
    }
}
