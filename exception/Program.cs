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
            
             
        }
    }
}
