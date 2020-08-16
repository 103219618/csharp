using System.Collections.Generic;

namespace exception
{
    public class Room
    {
        public List<Person> person;
        public int maxPersons = 2;

        public Room()
        {
            this.person = new List<Person>();
            this.maxPersons = 2;
        }

        public void AddPerson(Person newPerson)
        {
            this.person.Add(newPerson);
        }

        public void EntryDetails()
        {
            foreach (Person x in this.person)
            {
System.Console.WriteLine("Please Select Room Number: (TD224 OR AGSE111) ?");
            }
        }
    }
}