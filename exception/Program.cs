using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person("John Doe");
            Person Jane = new Person("Jane Black");

            Room r = new Room();
            r.AddPerson(John);
            r.AddPerson(Jane);

            r.EntryDetails();
            System.Console.WriteLine();
            string Room = System.Console.ReadLine();
            try
            {
                if (Room != "TD224" && Room != "AGSE111")
                {
                    throw new Exception();
                }
            }
            catch
            {
                System.Console.WriteLine("Please Check the Room & Try Again!!!");
            }

            System.Console.WriteLine("Please Enter Name");
            string Name = System.Console.ReadLine();
            try
            {
                if (Name != "John Doe" && Name != "Jane Black")
                {
                    throw new Exception();
                }
            }
            catch
            {
                System.Console.WriteLine("Incorrect Name!!!");
            }
        }
    }
}
