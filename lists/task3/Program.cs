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
                    System.Console.WriteLine("^^^Reverse Order of Above Words^^^");
                    wordlist.Reverse();
                    wordlist.ForEach(x => { Console.WriteLine(x); });
                }
                else
                {
                    Console.WriteLine("Please Enter a word?");
                    wordlist.Add(Console.ReadLine());
                }

                Console.ReadKey();

            }
        }
    }
}