using System;

namespace task7
{
    class Program
    {
        static void toPower()
        {
            int baseNum;
            int powNum;
            int result = 1;

            Console.WriteLine("Input Base number: ");
            baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the Exponent: ");
            powNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            Console.WriteLine("So, the number " + baseNum + " ^(to the power) " + powNum + " = " + result);

        }
        static void Main(string[] args)
        {
            toPower();
        }
    }
}
