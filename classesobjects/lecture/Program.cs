using System;

namespace lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new car
            Engine e1 = new Engine(4, 500);
            Car c2 = new Car("zxc987", 8, 0, 0, 0, e1);
            Car c3 = new Car("ABC123", 5, 0, 0, 0, 6, 300);

            Console.WriteLine("Before: " + c2.Passengers);
            c2.UpdatePassengers(5);
            Console.WriteLine("After: " + c2.Passengers);
            c2.UpdatePassengers(-6);
            Console.WriteLine("After: " + c2.Passengers);

            Console.WriteLine("Before: " + c3.en.NumCylinders);
            
            Console.WriteLine("Before: " + c2.en.NumCylinders);


        }
    }

    class Engine
    {
        public int NumCylinders;
        public int CylinderSize;

        //constructor
        public Engine(int nc, int cs)
        {
            this.NumCylinders = nc;
            this.CylinderSize = cs;
        }
        //operation
        public void Rev()
        {
            Console.WriteLine("Vroom Vroom");
        }

    }

    class Car
    {
        //attributes
        public string Rego;
        public int PassengerLimit;
        public int Passengers;
        public int Xcord;
        public int Ycord;
        public Engine en;

        //=================================
        // constructors
        public Car()
        {
            this.Rego = "";
            this.PassengerLimit = 0;
            this.Passengers = 0;
            this.Xcord = 0;
            this.Ycord = 0;
            this.en = null;
        }

        public Car(string rego, int pl, int pass, int x, int y, Engine e)
        {
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers = pass;
            this.Xcord = x;
            this.Ycord = y;
            this.en = e;
        }

        public Car(string rego, int pl, int pass, int x, int y, int nc, int cs)
        {
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers = pass;
            this.Xcord = x;
            this.Ycord = y;
            this.en = new Engine(nc, cs);
        }


        //=================================
        //operations

        /// adds number of newPassengers to passengers. To remove passengers provide negative newPassengers value
        public void UpdatePassengers(int newPassengers)
        {
            // check to not exceed passenger limit

            if (this.Passengers + newPassengers <= this.PassengerLimit && this.Passengers + newPassengers >= 0)
            {
                this.Passengers += newPassengers;
            }
        }

        public void Move(int newX, int newY)
        {
            this.Xcord = newX;
            this.Ycord = newY;

        }
    }
}
