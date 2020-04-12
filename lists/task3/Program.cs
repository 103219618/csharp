using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordlist = new List<string>();


            for (int i = 0; i <= wordlist.Count; i++)
            {

                if (wordlist.Contains("stop"))
                {
                    Console.WriteLine("=============================================");
                    Console.WriteLine("!!!The Words you entered in Reverse Order!!!");
                    Console.WriteLine("=============================================");
                    wordlist.Reverse();

                    // if we want to exclude the word stop from the display
                    // wordlist.RemoveAt(index: 0);

                    wordlist.ForEach(x => { Console.WriteLine(x); });

                }
                else
                {
                    Console.WriteLine("Please Enter a word?");
                    wordlist.Add((Console.ReadLine()));
                }
            }


            Console.ReadKey();
        }
    }
}
