using System;

namespace lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new car
            Car c1 = new Car();
            Car c2 = new Car("ABC123", 5, 0, 0, 0);

            Console.WriteLine("Before: " + c2.Passengers);
            c2.UpdatePassengers(5);
            Console.WriteLine("After: " + c2.Passengers);

            c2.UpdatePassengers(-6);
            Console.WriteLine("After: " + c2.Passengers);


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

        //=================================
        // constructors
        public Car()
        {
            this.Rego = "";
            this.PassengerLimit = 0;
            this.Passengers = 0;
            this.Xcord = 0;
            this.Ycord = 0;
        }

        public Car(string rego, int pl, int pass, int x, int y)
        {
            this.Rego = rego;
            this.PassengerLimit = pl;
            this.Passengers = pass;
            this.Xcord = x;
            this.Ycord = y;
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
