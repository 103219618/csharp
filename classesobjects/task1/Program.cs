using System;
using System.Linq;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate cookie
            var clr1 = new Color(255, 255, 0, "Yellow");
            var clr2 = new Color(128, 128, 0, "Olive");
            var clr3 = new Color(0, 0, 255, "Blue");

            var ck1 = new Cookie(25, "Crescent", clr1);
            var ck2 = new Cookie(30, "Round", clr2);
            var ck3 = new Cookie(20, "Square", clr3);
            var ck4 = new Cookie(40, "Car", clr2);

            Console.WriteLine();
            Console.WriteLine("The Weight of the Cookie is " + ck1.weight + " grams and the Shape is " + ck1.shape + " and the Color is " + clr1.name + ".");
            Console.WriteLine();
            Console.WriteLine("The Weight of the Cookie is " + ck2.weight + " grams and the Shape is " + ck2.shape + " and the Color is " + clr2.name + ".");
            Console.WriteLine();
            Console.WriteLine("The Weight of the Cookie is " + ck3.weight + " grams and the Shape is " + ck3.shape + " and the Color is " + clr3.name + ".");
            Console.WriteLine();
            Console.WriteLine("The Weight of the Cookie is " + ck4.weight + " grams and the Shape is " + ck2.shape + " and the Color is " + clr2.name + ".");
            Console.WriteLine();
        }
    }


    // class cookies
    class Cookie
    {
        //attributes
        public int weight;
        public string shape;
        public Color clr;

        //constructors
        public Cookie(int w, string s)
        {
            this.weight = 0;
            this.shape = "";
        }

        public Cookie(int w, string s, Color n)
        {
            this.weight = w;
            this.shape = s;
            this.clr = n;
        }

    }

    // class color
    class Color
    {
        // attributes
        public int red = 0;
        public int green = 0;
        public int blue = 0;
        public string name = "";

        // constructors
        public Color(int r, int g, int b, string n)
        {
            this.red = r;
            this.blue = b;
            this.green = g;
            this.name = n;
        }
    }
}
