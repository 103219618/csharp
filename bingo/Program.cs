using System;

namespace bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game("John", "Jane");
            g.Start();
        }
    }
}
