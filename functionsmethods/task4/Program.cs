using System;

namespace task4
{
    class Program
    {
        static int SpaceCount(string str)
        {
            int spaceCo = 0;
            string space1;
            for (int i = 0; i < str.Length; i++)
            {
                space1 = str.Substring(i, 1);
                if (space1 == " ")
                    spaceCo++;
            }
            return spaceCo;
        }
        static void Main()
        {
            string space2;
            Console.Write("Please input a string: ");
            space2 = Console.ReadLine();
            Console.WriteLine("'" + space2 + "'" + " contains " + SpaceCount(space2) + " spaces");
        }
    }
}
