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

            Console.Write("Entry Date (Format - MM/DD/YY): ");
            try
            {
                DateTime DateEntered = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Incorrect Datatype Entered, {ex.Message}, Please Try Again!");
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object Doesn't Exist, Closing Program... - {ex.Message}, START AGAIN PLEASE! ");
                System.Environment.Exit(1);
            }

            Console.Write("Entry Time (Format - HH:MM): ");
            try
            {
                DateTime TimeEntered = DateTime.Parse(Console.ReadLine());
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message},let's Do it again ");
                System.Environment.Exit(1);
            }

            Console.Write("Duration Room Was Booked: ");
            int TimeStayed = int.Parse(Console.ReadLine());
        }
    }
}
